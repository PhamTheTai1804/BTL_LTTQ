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
using BTL_LTTQ.Classes;

namespace Client
{
    public partial class LoginForm : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        public LoginForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.IsRemembered)
            {
                UserName.Text = Properties.Settings.Default.UserName;
                Password.Text = Properties.Settings.Default.Password;
                SaveLogin.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string Result="";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#Login" + username + "," + password;
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

            if (Result!="NotFound")
            {
                if (SaveLogin.Checked)
                {
                    Properties.Settings.Default.UserName = username;
                    Properties.Settings.Default.IsRemembered = true;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = string.Empty;
                    Properties.Settings.Default.Password= string.Empty;
                    Properties.Settings.Default.IsRemembered = false;
                    Properties.Settings.Default.Save();
                }
                ClientIndex index = new ClientIndex(Result);
                index.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
