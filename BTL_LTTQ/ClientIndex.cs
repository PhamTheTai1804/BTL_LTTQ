using BTL_LTTQ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Client
{
    public partial class ClientIndex : Form
    {
        private string MyID;
        DataBaseProcess db = new DataBaseProcess();
        public ClientIndex(string id)
        {
            InitializeComponent();
            this.Size = new Size(1280, 900); 
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point(300, 50);          
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
            MyID = id;
        }

        private void ClientIndex_Load(object sender, EventArgs e)
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#LoadFr"+MyID+"FillToEnough";
                byte[] data = Encoding.UTF8.GetBytes(RequestLogin);
                client.Send(data);
                byte[] dataReturn = new byte[1024 * 5000];
                int bytesRead = client.Receive(dataReturn);
                Result = Encoding.UTF8.GetString(dataReturn, 0, bytesRead);
            }
            catch
            {
                MessageBox.Show("Can't connect to server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally { client.Close(); };

            string[] listFr=Result.Split(';');
            int lct = 0;
            for (int i=0;i< listFr.Length-1;i++)
            {
                string path = @"C:\Users\theta\OneDrive\Hình ảnh\Legion'sDragonWallpaper\Legion Dragon Red.jpg";
                Image image;
                byte[] img = File.ReadAllBytes(path);
                using (MemoryStream ms = new MemoryStream(img))
                {
                    image = Image.FromStream(ms);
                }
                string[] InfoCertain = listFr[i].Split(',');
                UserControlAvatar avt = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], image);
                avt.Location = new Point(lct, 0);
                lct += 130;
                this.Controls.Add(avt);
            }
        }
    }
}

