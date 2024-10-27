using BTL_LTTQ.Classes;
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
            string sqlSelect = "select RIGHT('000'+CAST(f.[MaBanBe] AS VARCHAR(3)),3),u.[TenDangNhap]\r\nfrom [dbo].[BanBe] f\r\nINNER JOIN [dbo].[NguoiDung] u\r\nON f.MaBanBe=u.MaNguoiDung\r\nwhere f.[MaNguoiDung] = @IDUser";

            SqlCommand command = new SqlCommand(sqlSelect, db.GetConnection());
            command.Parameters.AddWithValue("@IDUser",MyID );
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(dt);
            int lct = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string path = @"C:\Users\theta\OneDrive\Hình ảnh\Legion'sDragonWallpaper\Legion Dragon Red.jpg";
                Image image;
                byte[] img = File.ReadAllBytes(path);
                using (MemoryStream ms = new MemoryStream(img))
                {
                    image = Image.FromStream(ms);
                }
                UserControlAvatar avt = new UserControlAvatar(MyID,dr[0].ToString(), dr[1].ToString(), image);
                avt.Location = new Point(lct, 0);
                lct += 130;
                this.Controls.Add(avt);
            }
        }
    }
}

