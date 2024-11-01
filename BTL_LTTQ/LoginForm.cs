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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class LoginForm : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        public LoginForm()
        {
            InitializeComponent();
            PopulateComboBox();
            SetupDateTimePicker();
            SetupCheckedListBoxHobby();
            if (Properties.Settings.Default.IsRemembered)
            {
                UserName.Text = Properties.Settings.Default.UserName;
                Password.Text = Properties.Settings.Default.Password;
                SaveLogin.Checked = true;
            }
            panelRegister.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }
        private void PopulateComboBox()
        {
            comboBoxPopulate.Items.AddRange(new string[]
            {
        "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu",
        "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước",
        "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng",
        "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp",
        "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh",
        "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên",
        "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng",
        "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An",
        "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình",
        "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng",
        "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa",
        "Thừa Thiên Huế", "Tiền Giang", "TP Hồ Chí Minh", "Trà Vinh", "Tuyên Quang",
        "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"
            });
        }
        private void SetupDateTimePicker()
        {
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirth.MaxDate = DateTime.Today;
            dateTimePickerBirth.Value = DateTime.Today;
        }
        private void SetupCheckedListBoxHobby()
        {

            checkedListBoxHobby.Items.AddRange(new string[]
            {
        "Đọc sách", "Xem phim", "Du lịch", "Chơi thể thao",
        "Nghe nhạc", "Nấu ăn", "Chụp ảnh", "Mua sắm"
            });


            checkedListBoxHobby.Height = 150;
            checkedListBoxHobby.Width = buttonHobby.Width;
            checkedListBoxHobby.SelectedIndexChanged += (s, e) =>
            {
                checkedListBoxHobby.ClearSelected();
            };
        }

        private void buttonHobby_Click(object sender, EventArgs e)
        {
            checkedListBoxHobby.Visible = !checkedListBoxHobby.Visible;
            checkedListBoxHobby.BringToFront();
            checkedListBoxHobby.Location = new Point(buttonHobby.Left, buttonHobby.Bottom);
        }

        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string Result = "";
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

            if (Result != "NotFound")
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
                    Properties.Settings.Default.Password = string.Empty;
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


        private void buttonRes_Click_1(object sender, EventArgs e)
        {
            int check = 0;
            if (textBoxName.Text == string.Empty)
            {
                lblWarnName.Visible = true;
                check = 1;
            }
            if (comboBoxPopulate.Text == string.Empty)
            { 
                WarnPopulate.Visible = true;
                check = 1;
            }
            if (textBoxUserName.Text == string.Empty)
            {
                WarnUserName.Visible = true;
                check = 1;
            }
            else WarnUserName.Visible = false;
            if (textBoxPassword.Text == string.Empty)
            {
                WarnPass.Visible = true;
                check = 1;
            }
            if (textBoxConfirm.Text != textBoxPassword.Text)
            {
                WarnConfirm.Visible = true;
                check = 1;
            }
            if (CheckUserNameExist(textBoxUserName.Text))
            {
                WarnUserExists.Visible = true;
                check = 1;
            }
            //gửi tín hiệu server lưu vào db
            if(check==0)
            {
                IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                try
                {
                    string hobby = "";
                    foreach(var item in checkedListBoxHobby.CheckedItems)
                    {
                        hobby += item.ToString()+":";
                    }
                    if(textBoxDifHob.Text!=string.Empty) hobby += textBoxDifHob.Text;
                    else hobby = hobby.Substring(0,hobby.Length-1);
                    client.Connect(IP);                   
                    string RequestLogin = "#Regis" + textBoxName.Text + "," + dateTimePickerBirth.Value.ToString("dd/MM/yyyy") + "," + comboBoxPopulate.SelectedItem.ToString() + "," + hobby + "," + textBoxUserName.Text + "," + textBoxPassword.Text;
                    byte[] data = Encoding.UTF8.GetBytes(RequestLogin);
                    client.Send(data);
                    DialogResult result = MessageBox.Show("Bạn đã đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {                       
                        panelRegister.Visible = false;
                        panelLogin.Visible = true;
                    }                  
                }
                catch
                {
                    MessageBox.Show("Can't connect to server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
                finally { client.Close(); };
            }
        }
        private bool CheckUserNameExist(string username)
        {
            string Result = "";
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                string RequestLogin = "#Exist" + username;
                byte[] data = Encoding.UTF8.GetBytes(RequestLogin);
                client.Send(data);
                byte[] dataReturn = new byte[1024 * 5000];
                int bytesRead = client.Receive(dataReturn);
                Result = Encoding.UTF8.GetString(dataReturn, 0, bytesRead);
            }
            catch
            {
                MessageBox.Show("Can't connect to server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { client.Close(); };
            if(Result=="1") return true;
            return false;
        }
    }
}
