namespace Client
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            buttonRegister = new Button();
            label1 = new Label();
            mainPanel = new Panel();
            panelLogin = new Panel();
            groupBox1 = new GroupBox();
            buttonEnter = new Button();
            SaveLogin = new CheckBox();
            Password = new TextBox();
            UserName = new TextBox();
            label2 = new Label();
            panelRegister = new Panel();
            WarnConfirm = new Label();
            WarnUserExists = new Label();
            WarnPass = new Label();
            WarnUserName = new Label();
            WarnPopulate = new Label();
            lblWarnBirth = new Label();
            lblWarnName = new Label();
            buttonHobby = new Button();
            textBoxDifHob = new TextBox();
            checkedListBoxHobby = new CheckedListBox();
            label10 = new Label();
            comboBoxPopulate = new ComboBox();
            label9 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            label8 = new Label();
            textBoxName = new TextBox();
            label7 = new Label();
            textBoxConfirm = new TextBox();
            buttonRes = new Button();
            label6 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            mainPanel.SuspendLayout();
            panelLogin.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonLogin.Location = new Point(86, 23);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(282, 66);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Đăng Nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonRegister.Location = new Point(411, 23);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(282, 66);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Đăng Ký";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 84);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(panelLogin);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(7, 113);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(781, 692);
            mainPanel.TabIndex = 4;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(groupBox1);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new Point(219, 88);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(349, 314);
            panelLogin.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonEnter);
            groupBox1.Controls.Add(SaveLogin);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(UserName);
            groupBox1.Location = new Point(22, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 316);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(8, 102, 255);
            buttonEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(19, 205);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(271, 52);
            buttonEnter.TabIndex = 11;
            buttonEnter.Text = "đăng nhập";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click_1;
            // 
            // SaveLogin
            // 
            SaveLogin.AutoSize = true;
            SaveLogin.Location = new Point(19, 167);
            SaveLogin.Name = "SaveLogin";
            SaveLogin.Size = new Size(130, 24);
            SaveLogin.TabIndex = 10;
            SaveLogin.Text = "Lưu đăng nhập";
            SaveLogin.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.Location = new Point(18, 99);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Nhập mật khẩu";
            Password.Size = new Size(272, 45);
            Password.TabIndex = 9;
            // 
            // UserName
            // 
            UserName.Location = new Point(18, 26);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Nhập tên đăng nhập";
            UserName.Size = new Size(272, 49);
            UserName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(84, -4);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 7;
            label2.Text = "Đăng Nhập";
            // 
            // panelRegister
            // 
            panelRegister.AutoScroll = true;
            panelRegister.Controls.Add(WarnConfirm);
            panelRegister.Controls.Add(WarnUserExists);
            panelRegister.Controls.Add(WarnPass);
            panelRegister.Controls.Add(WarnUserName);
            panelRegister.Controls.Add(WarnPopulate);
            panelRegister.Controls.Add(lblWarnBirth);
            panelRegister.Controls.Add(lblWarnName);
            panelRegister.Controls.Add(buttonHobby);
            panelRegister.Controls.Add(textBoxDifHob);
            panelRegister.Controls.Add(checkedListBoxHobby);
            panelRegister.Controls.Add(label10);
            panelRegister.Controls.Add(comboBoxPopulate);
            panelRegister.Controls.Add(label9);
            panelRegister.Controls.Add(dateTimePickerBirth);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(textBoxName);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(textBoxConfirm);
            panelRegister.Controls.Add(buttonRes);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(textBoxPassword);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(textBoxUserName);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(label4);
            panelRegister.Font = new Font("Segoe UI", 14F);
            panelRegister.Location = new Point(43, 113);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(742, 500);
            panelRegister.TabIndex = 5;
            // 
            // WarnConfirm
            // 
            WarnConfirm.AutoSize = true;
            WarnConfirm.Font = new Font("Segoe UI", 9F);
            WarnConfirm.ForeColor = Color.Red;
            WarnConfirm.Location = new Point(298, 693);
            WarnConfirm.Name = "WarnConfirm";
            WarnConfirm.Size = new Size(231, 20);
            WarnConfirm.TabIndex = 29;
            WarnConfirm.Text = "⊗ xác nhận mật khẩu không khớp";
            WarnConfirm.Visible = false;
            // 
            // WarnUserExists
            // 
            WarnUserExists.AutoSize = true;
            WarnUserExists.Font = new Font("Segoe UI", 9F);
            WarnUserExists.ForeColor = Color.Red;
            WarnUserExists.Location = new Point(298, 533);
            WarnUserExists.Name = "WarnUserExists";
            WarnUserExists.Size = new Size(190, 20);
            WarnUserExists.TabIndex = 28;
            WarnUserExists.Text = "⊗ tên đăng nhập đã tồn tại";
            WarnUserExists.Visible = false;
            // 
            // WarnPass
            // 
            WarnPass.AutoSize = true;
            WarnPass.Font = new Font("Segoe UI", 9F);
            WarnPass.ForeColor = Color.Red;
            WarnPass.Location = new Point(298, 615);
            WarnPass.Name = "WarnPass";
            WarnPass.Size = new Size(231, 20);
            WarnPass.TabIndex = 27;
            WarnPass.Text = "⊗ mật khẩu không được để trống";
            WarnPass.Visible = false;
            // 
            // WarnUserName
            // 
            WarnUserName.AutoSize = true;
            WarnUserName.Font = new Font("Segoe UI", 9F);
            WarnUserName.ForeColor = Color.Red;
            WarnUserName.Location = new Point(298, 533);
            WarnUserName.Name = "WarnUserName";
            WarnUserName.Size = new Size(266, 20);
            WarnUserName.TabIndex = 26;
            WarnUserName.Text = "⊗ tên đăng nhập không được để trống";
            WarnUserName.Visible = false;
            // 
            // WarnPopulate
            // 
            WarnPopulate.AutoSize = true;
            WarnPopulate.Font = new Font("Segoe UI", 9F);
            WarnPopulate.ForeColor = Color.Red;
            WarnPopulate.Location = new Point(298, 318);
            WarnPopulate.Name = "WarnPopulate";
            WarnPopulate.Size = new Size(214, 20);
            WarnPopulate.TabIndex = 25;
            WarnPopulate.Text = "⊗ địa chỉ không được để trống";
            WarnPopulate.Visible = false;
            // 
            // lblWarnBirth
            // 
            lblWarnBirth.AutoSize = true;
            lblWarnBirth.Font = new Font("Segoe UI", 9F);
            lblWarnBirth.ForeColor = Color.Red;
            lblWarnBirth.Location = new Point(298, 233);
            lblWarnBirth.Name = "lblWarnBirth";
            lblWarnBirth.Size = new Size(0, 20);
            lblWarnBirth.TabIndex = 24;
            // 
            // lblWarnName
            // 
            lblWarnName.AutoSize = true;
            lblWarnName.Font = new Font("Segoe UI", 9F);
            lblWarnName.ForeColor = Color.Red;
            lblWarnName.Location = new Point(296, 160);
            lblWarnName.Name = "lblWarnName";
            lblWarnName.Size = new Size(212, 20);
            lblWarnName.TabIndex = 23;
            lblWarnName.Text = "⊗ họ tên không được để trống";
            lblWarnName.Visible = false;
            // 
            // buttonHobby
            // 
            buttonHobby.Location = new Point(294, 357);
            buttonHobby.Name = "buttonHobby";
            buttonHobby.Size = new Size(250, 42);
            buttonHobby.TabIndex = 22;
            buttonHobby.Text = "Chọn sở thích ";
            buttonHobby.UseVisualStyleBackColor = true;
            buttonHobby.Click += buttonHobby_Click;
            // 
            // textBoxDifHob
            // 
            textBoxDifHob.Location = new Point(294, 405);
            textBoxDifHob.Name = "textBoxDifHob";
            textBoxDifHob.PlaceholderText = "Khác...";
            textBoxDifHob.Size = new Size(250, 39);
            textBoxDifHob.TabIndex = 21;
            // 
            // checkedListBoxHobby
            // 
            checkedListBoxHobby.AllowDrop = true;
            checkedListBoxHobby.CheckOnClick = true;
            checkedListBoxHobby.FormattingEnabled = true;
            checkedListBoxHobby.Location = new Point(294, 357);
            checkedListBoxHobby.Name = "checkedListBoxHobby";
            checkedListBoxHobby.Size = new Size(250, 38);
            checkedListBoxHobby.TabIndex = 20;
            checkedListBoxHobby.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(160, 371);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 19;
            label10.Text = "Sở Thích :";
            // 
            // comboBoxPopulate
            // 
            comboBoxPopulate.DropDownHeight = 270;
            comboBoxPopulate.DropDownWidth = 250;
            comboBoxPopulate.FormattingEnabled = true;
            comboBoxPopulate.IntegralHeight = false;
            comboBoxPopulate.Location = new Point(296, 275);
            comboBoxPopulate.Name = "comboBoxPopulate";
            comboBoxPopulate.Size = new Size(248, 39);
            comboBoxPopulate.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(139, 286);
            label9.Name = "label9";
            label9.Size = new Size(116, 28);
            label9.TabIndex = 17;
            label9.Text = "Tỉnh Thành :";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Font = new Font("Segoe UI", 9F);
            dateTimePickerBirth.Location = new Point(292, 203);
            dateTimePickerBirth.MaxDate = new DateTime(2024, 10, 30, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(252, 27);
            dateTimePickerBirth.TabIndex = 16;
            dateTimePickerBirth.Value = new DateTime(2024, 10, 30, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(147, 203);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 15;
            label8.Text = "Ngày sinh :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(294, 118);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 39);
            textBoxName.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(148, 129);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 13;
            label7.Text = "Họ Và Tên :";
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.Location = new Point(294, 653);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(250, 39);
            textBoxConfirm.TabIndex = 7;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.FromArgb(8, 102, 255);
            buttonRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRes.ForeColor = Color.White;
            buttonRes.Location = new Point(294, 716);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(250, 52);
            buttonRes.TabIndex = 12;
            buttonRes.Text = "đăng ký";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(69, 664);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 6;
            label6.Text = "Xác nhận mật khẩu :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(294, 571);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 39);
            textBoxPassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(100, 582);
            label5.Name = "label5";
            label5.Size = new Size(155, 28);
            label5.TabIndex = 4;
            label5.Text = "Nhập mật khẩu :";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(296, 487);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(250, 39);
            textBoxUserName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 498);
            label3.Name = "label3";
            label3.Size = new Size(201, 28);
            label3.TabIndex = 2;
            label3.Text = "Nhập tên đăng nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(294, 17);
            label4.Name = "label4";
            label4.Size = new Size(134, 41);
            label4.TabIndex = 1;
            label4.Text = "Đăng ký";
            // 
            // button1
            // 
            button1.Location = new Point(359, 451);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 703);
            Controls.Add(panelRegister);
            Controls.Add(button1);
            Controls.Add(mainPanel);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private Button buttonRegister;
        private Label label1;
        private Panel mainPanel;
        private Panel panelRegister;
        private Label label4;
        private Panel panelLogin;
        private GroupBox groupBox1;
        private Button buttonEnter;
        private CheckBox SaveLogin;
        private TextBox Password;
        private TextBox UserName;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label3;
        private TextBox textBoxConfirm;
        private Label label6;
        private TextBox textBoxPassword;
        private Label label5;
        private Button button1;
        private Button buttonRes;
        private TextBox textBoxName;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxPopulate;
        private Label label9;
        private DateTimePicker dateTimePickerBirth;
        private Label label10;
        private TextBox textBoxDifHob;
        private CheckedListBox checkedListBoxHobby;
        private Button buttonHobby;
        private Label lblWarnBirth;
        private Label lblWarnName;
        private Label WarnUserExists;
        private Label WarnPass;
        private Label WarnUserName;
        private Label WarnPopulate;
        private Label WarnConfirm;
    }
}