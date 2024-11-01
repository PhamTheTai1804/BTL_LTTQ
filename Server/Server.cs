using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTL_LTTQ.Classes;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server
{
    public partial class Server : Form
    {
        DataBaseProcess db=new DataBaseProcess();
        IPEndPoint IP;
        Socket server;
        Dictionary<string, Socket> clients;
        Dictionary<string,int> ClInDb;
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            ClInDb = new Dictionary<string, int>();
            LoadClientFromDb();
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
                    //Request Login
                    if (message.Substring(0, 6) == "#Login")
                    {
                        string[] info = message.Substring(6).Split(',');
                        string result = CheckLogin(info[0], info[1]);
                        if (result != "NotFound")
                        {
                            byte[] IDReturn = Encoding.UTF8.GetBytes(result);
                            client.Send(IDReturn);
                        }
                        else
                        {
                            byte[] IDReturn = Encoding.UTF8.GetBytes(result);
                            client.Send(IDReturn);
                        }
                    }
                    //Request Load Friends On Index Page
                    else if (message.Substring(0, 6) == "#LoadF")
                    {
                        string result = LoadIndex(message.Substring(6, 3));
                        byte[] ListFrReturn = Encoding.UTF8.GetBytes(result);
                        client.Send(ListFrReturn);
                    }
                    else if (message.Substring(0, 6) == "#LoadH")
                    {
                        string IDSend = message.Substring(6, 3);
                        string result = LoadHist(message.Substring(6, 3), message.Substring(9,3),message.Substring(12));
                        byte[] HistReturn = Encoding.UTF8.GetBytes(result);
                        client.Send(HistReturn);
                        clients[IDSend] = client;
                        NewMessage(result);
                    }
                    else if (message.Substring(0,6)=="#Exist")
                    {
                        string userName = message.Substring(6);
                        NewMessage(userName);
                        string result = CheckExist(userName);
                        byte[] Exist = Encoding.UTF8.GetBytes(result);
                        client.Send(Exist);
                    }
                    else if ( message.Substring(0,6)=="#Regis")
                    {
                        NewMessage(message);
                        string[] info = message.Substring(6).Split(',');
                        Register(info);
                    }
                    else
                    {
                        string IDSend = message.Substring(6, 3);
                        string IDReceive = message.Substring(9 , 3);
                        this.Invoke((MethodInvoker)delegate
                        {
                            NewMessage(message);

                        });
                        if (ClInDb.ContainsKey(IDReceive))
                        {
                            SaveMessageToDb(IDSend, IDReceive, message.Substring(12));
                            if (clients.ContainsKey(IDReceive))
                            {
                                Send(clients[IDReceive], message.Substring(12));
                            }
                            else
                            {
                                UpdateStatus(IDReceive, IDSend, "0");
                            }
                        }
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
        public string CheckLogin(string username, string password)
        {
            string sqlSelect = "SELECT RIGHT('000'+CAST([MaNguoiDung] AS VARCHAR(3)),3) FROM [dbo].[NguoiDung] WHERE [TenDangNhap] = @username AND [MatKhau] = @password";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "NotFound";
        }
        public string LoadIndex(string ID)
        {
            string sqlSelect = "select RIGHT('000'+CAST(f.[MaBanBe] AS VARCHAR(3)),3),u.[TenDangNhap],f.[TrangThai]\r\nfrom [dbo].[BanBe] f\r\nINNER JOIN [dbo].[NguoiDung] u\r\nON f.MaBanBe=u.MaNguoiDung\r\nwhere f.[MaNguoiDung] = @IDUser";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@IDUser", ID);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            string res = "";
            foreach (DataRow dr in dt.Rows)
            {
                res += dr[0].ToString() + "," + dr[1].ToString() + ","+dr[2].ToString()+";";
            }
            return res;
        }
        public string LoadHist(string SenderID, string ReceiverID, string stt)
        {
            string sqlSelect = "SELECT [NoiDung],RIGHT('000' + CAST([MaNguoiGui] AS VARCHAR(3)), 3)\r\nFROM [dbo].[TinNhan]\r\nWHERE ([MaNguoiGui] = @IDSend AND [MaNguoiNhan]=@IDRec) \r\nOR ([MaNguoiNhan] =@IDSend AND [MaNguoiGui]=@IDRec)\r\nORDER BY [ThoiGian]";
            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@IDSend", SenderID);
            command.Parameters.AddWithValue("@IDRec", ReceiverID);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            string res = "&^*";
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    res += dr[0].ToString() + "," + dr[1].ToString() + ";";
                }
            }
            //if this friend have unseen message , update db
            if(stt=="1")
            {
                UpdateStatus(SenderID, ReceiverID,stt);
            }    
            return res;
        }
        public void UpdateStatus(string SenderID, string ReceiverID, string stt)
        {
            string sqlInsert = "UPDATE [dbo].[BanBe]\r\nSET [TrangThai]=@vl\r\nWHERE [MaNguoiDung]=@Sid AND [MaBanBe]=@Rid";
            using (SqlCommand command = new SqlCommand(sqlInsert, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@Sid", SenderID);
                command.Parameters.AddWithValue("@Rid", ReceiverID);
                if(stt=="0") command.Parameters.AddWithValue("@vl", "1");
                else command.Parameters.AddWithValue("@vl", "0");
                db.OpenConnect();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnect();
            }
        }
        public void SaveMessageToDb(string SenderID,string ReceiverID,string content)
        {
            string sqlInsert = "INSERT INTO [dbo].[TinNhan]([MaNguoiGui],[MaNguoiNhan],[NoiDung])\r\nVALUES (@Sid,@Rid,@ctn)";
            using (SqlCommand command = new SqlCommand(sqlInsert, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@Sid", SenderID);
                command.Parameters.AddWithValue("@Rid", ReceiverID);
                command.Parameters.AddWithValue("@ctn", content);

                db.OpenConnect();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnect();
            }
        }
        public void LoadClientFromDb()
        {            
            string sqlSelect = "SELECT RIGHT('000'+CAST([MaNguoiDung] AS VARCHAR(3)),3)\r\nFROM [dbo].[NguoiDung]";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            for (int i=0;i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                ClInDb.Add(dr[0].ToString(),i);
            }
        }
        public string CheckExist(string username)
        {
            string sqlSelect = "SELECT 1\r\nFROM [dbo].[NguoiDung]\r\nWHERE [TenDangNhap] = @USN";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@USN", username);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            string res = "0";
            if (dt.Rows.Count > 0) res = "1";
            return res;
        }
        public void Register(string[] info)
        {
            string sqlInsert = "  INSERT INTO [dbo].[NguoiDung]([TenDangNhap],[MatKhau],[HoTen],[DiaChi])\r\n  VALUES (@USN,@PW,@N,@LC)";

            using (SqlCommand command = new SqlCommand(sqlInsert, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@USN", info[4]);
                command.Parameters.AddWithValue("@PW", info[5]);
                command.Parameters.AddWithValue("@N", info[0]);
                command.Parameters.AddWithValue("@LC", info[2]);

                db.OpenConnect();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnect();
            }
            string[] hobby = info[3].Split(":");
            string sqlAddHobby = "IF NOT EXISTS (SELECT 1 FROM [dbo].[SoThich] WHERE [TenSoThich] COLLATE SQL_Latin1_General_CP1_CI_AS = @nhb)\r\nBEGIN\r\n    INSERT INTO [dbo].[SoThich] ([TenSoThich]) VALUES (@nhb);\r\nEND";
            using (SqlCommand command = new SqlCommand(sqlAddHobby, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@nhb", hobby[hobby.Length-1]);
                db.OpenConnect();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnect();
            }
            string sqlUser_Hobby = "INSERT INTO [dbo].[NguoiDung_SoThich]([MaNguoiDung],[MaSoThich])\r\nVALUES((SELECT [MaNguoiDung] FROM [dbo].[NguoiDung] WHERE [TenDangNhap]=@us),(SELECT [MaSoThich] FROM [dbo].[SoThich] WHERE [TenSoThich]=@hb ));";
            foreach(string item in hobby)
            {
                using (SqlCommand command = new SqlCommand(sqlUser_Hobby, db.GetConnection()))
                {
                    command.Parameters.AddWithValue("@us", info[4]);
                    command.Parameters.AddWithValue("@hb", item);
                    db.OpenConnect();
                    int rowsAffected = command.ExecuteNonQuery();
                    db.CloseConnect();
                }
            }    
        }
    }
}
