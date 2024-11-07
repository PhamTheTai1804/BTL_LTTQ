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
using System.Drawing.Drawing2D;
using MaterialSkin.Controls;


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
            panelNotifications.Visible = false;
            MyID = id;
        }

        private void ClientIndex_Load(object sender, EventArgs e)
        {
            LoadIndex();
            //LoadCommunityPage();
            LoadAllUser();
            ReceiveFriendRequest();
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
            if(Result!="NoFriend")
            {
                string[] listFr = Result.Split('&');
                int lctOnl = 0;
                int lctConv = 0;
                for (int i = 0; i < listFr.Length - 1; i++)
                {
                    string[] InfoCertain = listFr[i].Split('$');
                    //UserControlAvatar receive MyID , Friend's ID , Friend's UserName , Friend's status 
                    UserControlAvatar avt = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], InfoCertain[2], Properties.Resources.Test);
                    bool sender = InfoCertain[4] == MyID;
                    bool unseen = InfoCertain[2] == "1";
                    Userconversation conversation = new Userconversation(avt, InfoCertain[3], sender, unseen);
                    conversation.Location = new Point(0, lctConv);
                    lctConv += 160;
                    panelAllFr.Controls.Add(conversation);
                    if (InfoCertain[5] == "1")
                    {
                        UserControlAvatar temp = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], InfoCertain[2], Properties.Resources.Test); ;
                        temp.Location = new Point(lctOnl, 0);
                        lctOnl += 130;
                        panelOnl.Controls.Add(temp);
                    }
                }
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
            foreach (string item in RcmFriends)
            {
                string[] InfoCertain = item.Split(',');
                UserControlAvatar avt = new UserControlAvatar(MyID, InfoCertain[0], InfoCertain[1], "0", Properties.Resources.Test);
                avt.Location = new Point(lct, 0);
                lct += 130;
                panelKNN.Controls.Add(avt);
            }
        }

        private void ReceiveFriendRequest()
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#RcvFr" + MyID;
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
            if (Result != "NoFriendRequest")
            {                
                string[] FriendRequests = Result.Split(';');
                int p_x = 20, p_y = 10;
                foreach (string FriendRequest in FriendRequests)
                {
                    string[] infoCertain = FriendRequest.Split(',');
                    UserProfileCard community = new UserProfileCard(MyID, infoCertain[0], infoCertain[1], Properties.Resources.Test);
                    community.Location = new Point(p_x, p_y);
                    p_x += 220;
                    if (p_x > panelNotifications.Width - 220) { p_x = 20; p_y += 330; }
                    panelNotifications.Controls.Add(community);
                }
            }
        }
        private void LoadAllUser()
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#LdAll" + MyID;
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
            string[] info = Result.Split(";");
            int p_x = 20, p_y = 10;
            foreach (string s in info)
            {
                string[] infoCertain = s.Split(",");
                UserProfileCard community = new UserProfileCard(MyID, infoCertain[0], infoCertain[1], Properties.Resources.Test);
                community.Location = new Point(p_x, p_y);
                p_x += 220;
                if (p_x > panelAddFr.Width - 220) { p_x = 20; p_y += 330; }
                panelAddFr.Controls.Add(community);
            }
        }



        private void ClientIndex_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.DeepSkyBlue;
            Color endColor = Color.LightBlue;

            // Tạo dải màu theo chiều ngang hoặc dọc
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, startColor, endColor, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panelAddFr_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.PowderBlue;
            Color endColor = Color.LightBlue;

            // Tạo dải màu theo chiều ngang hoặc dọc
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, startColor, endColor, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = true;
            panelFr.Visible = false;
            panelNotifications.Visible = false;
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            panelNotifications.Visible = false;
            panelIndex.Visible = false;
            panelFr.Visible = true;
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            panelNotifications.Visible = true;
            panelFr.Visible = false;
            panelIndex.Visible = false;
        }
    }
}

