﻿namespace Client
{
    partial class UserControlAvatar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picAvt = new PictureBox();
            lbAvt = new Label();
            picIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAvt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // picAvt
            // 
            picAvt.Location = new Point(25, 3);
            picAvt.Name = "picAvt";
            picAvt.Size = new Size(100, 100);
            picAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvt.TabIndex = 0;
            picAvt.TabStop = false;
            picAvt.Click += picAvt_Click;
            // 
            // lbAvt
            // 
            lbAvt.AutoSize = true;
            lbAvt.Location = new Point(25, 116);
            lbAvt.Name = "lbAvt";
            lbAvt.Size = new Size(50, 20);
            lbAvt.TabIndex = 1;
            lbAvt.Text = "label1";
            // 
            // picIcon
            // 
            picIcon.Location = new Point(122, 6);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(25, 25);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 2;
            picIcon.TabStop = false;
            // 
            // UserControlAvatar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picIcon);
            Controls.Add(lbAvt);
            Controls.Add(picAvt);
            Name = "UserControlAvatar";
            Load += UserControlAvatar_Load;
            Click += UserControlAvatar_Click;
            ((System.ComponentModel.ISupportInitialize)picAvt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvt;
        private Label lbAvt;
        private PictureBox picIcon;
    }
}
