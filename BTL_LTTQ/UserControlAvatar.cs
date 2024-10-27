using BTL_LTTQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControlAvatar : UserControl
    {
        public string FrID;
        public string MyID;
        public UserControlAvatar(string myid,string Yourid, string username, Image avatarImage)
        {
            InitializeComponent();
            lbAvt.Text = username;
            picAvt.Image = avatarImage;
            FrID = Yourid;
            MyID = myid;
            picAvt.Paint += (s, e) => DrawCircularAvatar(e.Graphics, picAvt.ClientRectangle);
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
            ClientChat clt = new ClientChat(MyID,FrID);
            clt.Show();
        }

        private void picAvt_Click(object sender, EventArgs e)
        {

        }
    }
}
