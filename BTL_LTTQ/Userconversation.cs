using BTL_LTTQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Userconversation : UserControl
    {
        private UserControlAvatar avatar;
        public Userconversation(UserControlAvatar avt, string message, bool Sender, bool Unseen)
        {
            InitializeComponent();
            this.Controls.Add(avt);
            if (Sender)
            {
                this.labelMessage.Text = "Bạn : ";
            }
            this.labelName.Text = avt.Username;
            avt.Username = "";
            this.labelMessage.Text += message;
            if (Unseen)
            {
                labelName.Font = new Font(labelName.Font, FontStyle.Bold);
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Bold);
            }
        }

        private void Userconversation_Click(object sender, EventArgs e)
        {
            labelName.Font = new Font(labelName.Font, FontStyle.Regular);
            labelMessage.Font = new Font(labelMessage.Font, FontStyle.Regular);
            ClientChat chat = new ClientChat(avatar.MyID, avatar.FrID, avatar.status);
            chat.Show();
        }
    }
}
