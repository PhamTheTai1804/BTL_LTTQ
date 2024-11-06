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
        public string status = "";
        public UserControlAvatar(string myid, string Yourid, string username, string stt, Image avatarImage)
        {
            InitializeComponent();
            lbAvt.Text = username;
            picAvt.Image = MakeCircularImage(avatarImage);
            FrID = Yourid;
            MyID = myid;
            status = stt;
            if (stt == "1") picIcon.Image = Properties.Resources.IconNewMessage;
        }
        // Thuộc tính công khai để thiết lập tên đăng nhập
        public string Username
        {
            get => lbAvt.Text;
            set => lbAvt.Text = value;
        }

        // Thuộc tính công khai để thiết lập ảnh đại diện

        // Hàm tạo ảnh tròn
        private Image MakeCircularImage(Image img)
        {
            // Tạo bitmap với kích thước của PictureBox
            Bitmap bmp = new Bitmap(picAvt.Width, picAvt.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Đặt SmoothingMode để làm mịn đường viền
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Tạo đường path hình tròn
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, bmp.Width - 1, bmp.Height - 1);

                    // Tạo hình tròn từ ảnh
                    g.SetClip(path);
                    g.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height));

                    // Tạo viền ngoài (nếu muốn)
                    using (Pen pen = new Pen(Color.White, 4)) // Màu viền là trắng
                    {
                        g.ResetClip(); // Bỏ clip để vẽ viền ngoài
                        g.DrawEllipse(pen, 0, 0, bmp.Width - 1, bmp.Height - 1);
                    }
                }
            }

            return bmp;
        }

        private void UserControlAvatar_Click(object sender, EventArgs e)
        {
            ClientChat chat = new ClientChat(MyID, FrID, status);
            chat.Show();
        }

        private void picAvt_Click(object sender, EventArgs e)
        {
            ClientChat chat = new ClientChat(MyID, FrID, status);
            chat.Show();
        }
    }
}
