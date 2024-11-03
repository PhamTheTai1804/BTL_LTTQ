
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BTL_LTTQ
{
    public partial class ClientChat : Form
    {
        IPEndPoint IP;
        Socket client;
        string FrID;
        string MyID;
        string status;
        private int currentYPosition = 0;

        public ClientChat(string myid,string uID, string stt)
        {
            MyID = myid;
            FrID = uID;
            status = stt;
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Size = new Size(1280, 900);

            this.Location = new Point(300, 50);
  
            this.MaximizeBox = false;
            Connect();            
        }

        public void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                AddSentMessage(client.LocalEndPoint.ToString());
                AddSentMessage(MyID);
                string message = "#LoadH"+MyID +FrID+status; 
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data);// send request to server
                byte[] dataReturn = new byte[1024 * 1000];
                int bytesRead = client.Receive(dataReturn);
                status = "0";
                LoadOldMessage(Encoding.UTF8.GetString(dataReturn, 0, bytesRead));
            }
            catch
            {
                MessageBox.Show("Can't connect to server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listenThread = new Thread(Receive);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        public void Disconnect()
        {
            client.Close();
        }

        public void Send()
        {
            if (!string.IsNullOrEmpty(textBoxChat.Text))
            {
                string message = "#Messg"+MyID + FrID + textBoxChat.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data);
                AddSentMessage(textBoxChat.Text);
            }
        }

        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesRead = client.Receive(data);
                    string message = Encoding.UTF8.GetString(data, 0, bytesRead);

                    this.Invoke((MethodInvoker)delegate
                    {
                        AddReceivedMessage(message);                        
                    });
                }
            }
            catch
            {
                Disconnect();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Send();
            textBoxChat.Clear();
        }

        private void MakeRoundedCorners(Panel panel, int cornerRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            graphicsPath.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            graphicsPath.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            graphicsPath.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            graphicsPath.CloseAllFigures();
            panel.Region = new Region(graphicsPath);
        }

        private void AddSentMessage(string message)
        {
            Panel sentMessagePanel = new Panel();
            Label messageLabel = new Label();

            messageLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            messageLabel.Text = message;
            messageLabel.MaximumSize = new Size(450, 0);
            messageLabel.AutoSize = true;
            
            sentMessagePanel.Size = new Size(messageLabel.PreferredSize.Width + 20, messageLabel.PreferredSize.Height + 10);
            messageLabel.ForeColor = Color.White;

            sentMessagePanel.BackColor = Color.Blue;
            MakeRoundedCorners(sentMessagePanel, 10);
            sentMessagePanel.Location = new Point(ContainerChat.Width - sentMessagePanel.Width - 22, currentYPosition+ContainerChat.AutoScrollPosition.Y);
            Console.WriteLine(ContainerChat.Location);
            sentMessagePanel.Controls.Add(messageLabel);
            ContainerChat.Controls.Add(sentMessagePanel);
            ContainerChat.VerticalScroll.Value = ContainerChat.VerticalScroll.Maximum;
            ContainerChat.PerformLayout();
            currentYPosition += sentMessagePanel.Height + 10;
        }

        private void AddReceivedMessage(string message)
        {
            Panel receivedMessagePanel = new Panel();
            Label messageLabel = new Label();

            messageLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            messageLabel.Text = message;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(450, 0);
            receivedMessagePanel.Size = new Size(messageLabel.PreferredSize.Width + 20, messageLabel.PreferredSize.Height + 10);
            messageLabel.ForeColor = Color.Black;

            receivedMessagePanel.BackColor = Color.LightGray;
            MakeRoundedCorners(receivedMessagePanel, 10);
            receivedMessagePanel.Location = new Point(10, currentYPosition + ContainerChat.AutoScrollPosition.Y);
            receivedMessagePanel.Controls.Add(messageLabel);
            ContainerChat.Controls.Add(receivedMessagePanel);
            currentYPosition += receivedMessagePanel.Height + 10;
        }
        public void LoadOldMessage(string content)
        {
            if (content == "&^*") {  return; }
            string[] lstMessage = content.Substring(3).Split(';');
            for (int i = 0; i < lstMessage.Length - 1; i++)
            {
                string[] split = lstMessage[i].Split(',');
                if (split[1]==MyID) AddSentMessage(split[0]);
                else AddReceivedMessage(split[0]);
            }
        }
    }
}
