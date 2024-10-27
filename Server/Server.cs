using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        Socket server;
        Dictionary<string, Socket> clients;

        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        public void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 9998);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            clients = new Dictionary<string, Socket>();

            server.Bind(IP);
            Thread listenThread = new Thread(ListenForClients);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ListenForClients()
        {
            try
            {
                server.Listen(100);
                while (true)
                {
                    Socket client = server.Accept();
                    NewMessage(client.RemoteEndPoint.ToString());
                    Thread receiveThread = new Thread(Receive);
                    receiveThread.IsBackground = true;
                    receiveThread.Start(client);
                }
            }
            catch
            {
                IP = new IPEndPoint(IPAddress.Any, 9998);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
        }

        public void Disconnect()
        {
            server.Close();
        }

        public void Send(Socket client, string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data);
            }
        }

        public void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesRead = client.Receive(data);
                    string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                    string IDSend = message.Substring(0, 3); 
                    string IDReceive = message.Substring(message.Length - 3);  

                    clients[IDSend] = client;
                    NewMessage(message);

                    if (clients.ContainsKey(IDReceive))
                    {
                        
                        Send(clients[IDReceive], message.Substring(3, message.Length - 6));
                    }
                }
            }
            catch
            {
                
                client.Close();
            }
        }

        public void NewMessage(string message)
        {
            richTextBoxChat.AppendText(message + Environment.NewLine);
            richTextBoxChat.SelectionStart = richTextBoxChat.Text.Length;
            richTextBoxChat.ScrollToCaret();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach (var item in clients)
            {
                Send(item.Value, textBoxChat.Text);
            }
            NewMessage(textBoxChat.Text);
            textBoxChat.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
