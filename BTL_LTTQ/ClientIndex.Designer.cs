﻿using MaterialSkin.Controls;

namespace Client
{
    partial class ClientIndex
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
            panelIndex = new Panel();
            panelOnl = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelAllFr = new Panel();
            panelFr = new Panel();
            panelAddFr = new Panel();
            label4 = new Label();
            label3 = new Label();
            panelKNN = new Panel();
            panel1 = new Panel();
            btnProfile = new Button();
            btnNotifications = new Button();
            btnCommunity = new Button();
            btnIndex = new Button();
            panelNotifications = new Panel();
            panelIndex.SuspendLayout();
            panelFr.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelIndex
            // 
            panelIndex.BackColor = Color.Transparent;
            panelIndex.Controls.Add(panelOnl);
            panelIndex.Controls.Add(label2);
            panelIndex.Controls.Add(label1);
            panelIndex.Controls.Add(panelAllFr);
            panelIndex.Location = new Point(12, 62);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(1238, 858);
            panelIndex.TabIndex = 7;
            // 
            // panelOnl
            // 
            panelOnl.BackColor = Color.White;
            panelOnl.Location = new Point(3, 65);
            panelOnl.Name = "panelOnl";
            panelOnl.Size = new Size(1232, 170);
            panelOnl.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 266);
            label2.Name = "label2";
            label2.Size = new Size(218, 40);
            label2.TabIndex = 3;
            label2.Text = "Bạn Bè Của Bạn";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(234, 40);
            label1.TabIndex = 2;
            label1.Text = "Đang Hoạt Động";
            // 
            // panelAllFr
            // 
            panelAllFr.AutoScroll = true;
            panelAllFr.BackColor = Color.Transparent;
            panelAllFr.Location = new Point(3, 329);
            panelAllFr.Margin = new Padding(0, 3, 3, 3);
            panelAllFr.Name = "panelAllFr";
            panelAllFr.Size = new Size(1232, 526);
            panelAllFr.TabIndex = 1;
            // 
            // panelFr
            // 
            panelFr.BackColor = Color.Transparent;
            panelFr.Controls.Add(panelAddFr);
            panelFr.Controls.Add(label4);
            panelFr.Controls.Add(label3);
            panelFr.Controls.Add(panelKNN);
            panelFr.Location = new Point(12, 62);
            panelFr.Name = "panelFr";
            panelFr.Size = new Size(1235, 849);
            panelFr.TabIndex = 4;
            panelFr.Paint += panelFr_Paint;
            // 
            // panelAddFr
            // 
            panelAddFr.AutoScroll = true;
            panelAddFr.BackColor = Color.Transparent;
            panelAddFr.Location = new Point(15, 461);
            panelAddFr.Name = "panelAddFr";
            panelAddFr.Size = new Size(1182, 388);
            panelAddFr.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 17F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 416);
            label4.Name = "label4";
            label4.Size = new Size(115, 40);
            label4.TabIndex = 2;
            label4.Text = "Kết Bạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 17F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 7);
            label3.Name = "label3";
            label3.Size = new Size(421, 40);
            label3.TabIndex = 1;
            label3.Text = "Những Người Có Thể Bạn Thích";
            // 
            // panelKNN
            // 
            panelKNN.BackColor = Color.Transparent;
            panelKNN.Location = new Point(9, 63);
            panelKNN.Name = "panelKNN";
            panelKNN.Size = new Size(1191, 325);
            panelKNN.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnNotifications);
            panel1.Controls.Add(btnCommunity);
            panel1.Controls.Add(btnIndex);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 55);
            panel1.TabIndex = 8;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 11F);
            btnProfile.Location = new Point(399, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(126, 52);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Hồ Sơ";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            btnNotifications.Font = new Font("Segoe UI", 11F);
            btnNotifications.Location = new Point(267, 0);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(126, 52);
            btnNotifications.TabIndex = 2;
            btnNotifications.Text = "Thông Báo";
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnCommunity
            // 
            btnCommunity.Font = new Font("Segoe UI", 11F);
            btnCommunity.Location = new Point(135, 0);
            btnCommunity.Name = "btnCommunity";
            btnCommunity.Size = new Size(126, 52);
            btnCommunity.TabIndex = 1;
            btnCommunity.Text = "Kết Nối";
            btnCommunity.UseVisualStyleBackColor = true;
            btnCommunity.Click += btnCommunity_Click;
            // 
            // btnIndex
            // 
            btnIndex.Font = new Font("Segoe UI", 11F);
            btnIndex.Location = new Point(3, 0);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(126, 52);
            btnIndex.TabIndex = 0;
            btnIndex.Text = "Trang Chủ";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click;
            // 
            // panelNotifications
            // 
            panelNotifications.AutoScroll = true;
            panelNotifications.BackColor = Color.White;
            panelNotifications.Location = new Point(12, 62);
            panelNotifications.Name = "panelNotifications";
            panelNotifications.Size = new Size(1238, 858);
            panelNotifications.TabIndex = 9;
            // 
            // ClientIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1262, 931);
            Controls.Add(panelNotifications);
            Controls.Add(panel1);
            Controls.Add(panelFr);
            Controls.Add(panelIndex);
            Name = "ClientIndex";
            Text = "ClientIndex";
            Load += ClientIndex_Load;
            Paint += ClientIndex_Paint;
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            panelFr.ResumeLayout(false);
            panelFr.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelIndex;
        private Label label2;
        private Label label1;
        private Panel panelAllFr;
        private Panel panelFr;
        private Panel panelAddFr;
        private Label label4;
        private Label label3;
        private Panel panelKNN;
        private Panel panelOnl;
        private Panel panel1;
        private Button btnProfile;
        private Button btnNotifications;
        private Button btnCommunity;
        private Button btnIndex;
        private Panel panelNotifications;
    }
}