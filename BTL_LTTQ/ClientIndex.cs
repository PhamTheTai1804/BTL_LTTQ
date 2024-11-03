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
        public ClientIndex(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 50);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            panelFr.Visible = false;
            MyID = id;
        }

        private void ClientIndex_Load(object sender, EventArgs e)
        {
            LoadIndex();
            LoadCommunityPage();
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = true;
            panelFr.Visible = false;
        }

        private void buttonFr_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = false;
            panelFr.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void LoadIndex()
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#LoadF" + MyID;
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

            string[] listFr = Result.Split(';');
            int lctOnl = 0;
            int lctOffl = 0;
            for (int i = 0; i < listFr.Length - 1; i++)
            {
                string[] InfoCertain = listFr[i].Split(',');
                //UserControlAvatar receive MyID , Friend's ID , Friend's UserName , Friend's status 
                UserControlAvatar avt = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], InfoCertain[2], Properties.Resources.Test);
                if (InfoCertain[3] == "1")
                {
                    avt.Location = new Point(lctOnl, 0);
                    lctOnl += 130;
                    panelOnl.Controls.Add(avt);
                }
                avt.Location = new Point(lctOffl, 0);
                lctOffl += 130;
                panelAllFr.Controls.Add(avt);
            }
        }
        public void LoadCommunityPage()
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#APIAI" + MyID;
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
            string[] RcmFriends = Result.Split(';');
            int lct = 0;
            foreach(string item in RcmFriends)
            {
                string[] InfoCertain = item.Split(',');                
                UserControlAvatar avt = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], "0", Properties.Resources.Test);
                avt.Location = new Point(lct, 0);
                lct += 130;
                panelKNN.Controls.Add(avt);
            }    
        }
        
    }
}

