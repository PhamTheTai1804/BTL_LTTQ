using System.Windows.Forms;

namespace BTL_LTTQ
{
    partial class ClientChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ContainerChat = new Panel();
            textBoxChat = new TextBox();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // ContainerChat
            // 
            ContainerChat.AutoScroll = true;
            ContainerChat.Location = new Point(31, 27);
            ContainerChat.Name = "ContainerChat";
            ContainerChat.Size = new Size(1200, 705);
            ContainerChat.TabIndex = 0;
            // 
            // textBoxChat
            // 
            textBoxChat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBoxChat.Location = new Point(31, 751);
            textBoxChat.Multiline = true;
            textBoxChat.Name = "textBoxChat";
            textBoxChat.Size = new Size(1030, 80);
            textBoxChat.TabIndex = 1;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.FromArgb(8, 102, 255);
            buttonSend.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSend.ForeColor = Color.White;
            buttonSend.Location = new Point(1067, 751);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(157, 80);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // ClientChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(textBoxChat);
            Controls.Add(ContainerChat);
            Name = "ClientChat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ContainerChat;
        private TextBox textBoxChat;
        private Button buttonSend;
    }
}
