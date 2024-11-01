using BTL_LTTQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControlAvatar : UserControl
    {
        public string FrID;
        public string MyID;
        public string status="";
        public UserControlAvatar(string myid,string Yourid, string username,string stt, Image avatarImage)
        {
            InitializeComponent();
            lbAvt.Text = username;
            picAvt.Image = avatarImage;
            FrID = Yourid;
            MyID = myid;
            status = stt;
            picAvt.Paint += (s, e) => DrawCircularAvatar(e.Graphics, picAvt.ClientRectangle);
            if(stt=="1") picIcon.Image = Properties.Resources.IconNewMessage;
        }
        private void DrawCircularAvatar(Graphics graphics, Rectangle bounds)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(bounds);
                picAvt.Region = new Region(path);
            }
        }

        private void UserControlAvatar_Load(object sender, EventArgs e)
        {

        }

        private void UserControlAvatar_Click(object sender, EventArgs e)
        {
            picIcon.Image = null;
            ClientChat clt = new ClientChat(MyID,FrID,status);
            clt.Show();

        }

        private void picAvt_Click(object sender, EventArgs e)
        {

        }
    }
}
