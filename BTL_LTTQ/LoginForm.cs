using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            string sqlSelect = "SELECT RIGHT('000'+CAST([MaNguoiDung] AS VARCHAR(3)),3) FROM [dbo].[NguoiDung] WHERE [TenDangNhap] = @username AND [MatKhau] = @password";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            if (dt.Rows.Count>0)
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
                ClientIndex index = new ClientIndex(dt.Rows[0][0].ToString());
                index.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
