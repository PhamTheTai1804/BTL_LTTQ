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
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonEnter = new Button();
            SaveLogin = new CheckBox();
            Password = new TextBox();
            UserName = new TextBox();
            groupBox1.SuspendLayout();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 197);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(287, 106);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 5;
            label2.Text = "Đăng Nhập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonEnter);
            groupBox1.Controls.Add(SaveLogin);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(UserName);
            groupBox1.Location = new Point(224, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 269);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(8, 102, 255);
            buttonEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(19, 192);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(271, 52);
            buttonEnter.TabIndex = 11;
            buttonEnter.Text = "đăng nhập";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // SaveLogin
            // 
            SaveLogin.AutoSize = true;
            SaveLogin.Location = new Point(18, 150);
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
            UserName.Location = new Point(18, 44);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Nhập tên đăng nhập";
            UserName.Size = new Size(272, 49);
            UserName.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonRegister;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonEnter;
        private CheckBox SaveLogin;
        private TextBox Password;
        private TextBox UserName;
    }
}