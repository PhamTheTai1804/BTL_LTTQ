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
            buttonIndex = new Button();
            buttonFr = new Button();
            panelIndex = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelAllFr = new Panel();
            panelOnl = new Panel();
            panelFr = new Panel();
            panelAddFr = new Panel();
            label4 = new Label();
            label3 = new Label();
            panelKNN = new Panel();
            panelIndex.SuspendLayout();
            panelFr.SuspendLayout();
            SuspendLayout();
            // 
            // buttonIndex
            // 
            buttonIndex.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonIndex.Location = new Point(9, 3);
            buttonIndex.Name = "buttonIndex";
            buttonIndex.Size = new Size(124, 47);
            buttonIndex.TabIndex = 0;
            buttonIndex.Text = "Trang Chủ";
            buttonIndex.UseVisualStyleBackColor = true;
            buttonIndex.Click += buttonIndex_Click;
            // 
            // buttonFr
            // 
            buttonFr.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonFr.Location = new Point(139, 3);
            buttonFr.Name = "buttonFr";
            buttonFr.Size = new Size(124, 47);
            buttonFr.TabIndex = 6;
            buttonFr.Text = "Kết Bạn";
            buttonFr.UseVisualStyleBackColor = true;
            buttonFr.Click += buttonFr_Click;
            // 
            // panelIndex
            // 
            panelIndex.BackColor = Color.Transparent;
            panelIndex.Controls.Add(label2);
            panelIndex.Controls.Add(label1);
            panelIndex.Controls.Add(panelAllFr);
            panelIndex.Controls.Add(panelOnl);
            panelIndex.Location = new Point(12, 62);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(1200, 750);
            panelIndex.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 238);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 3;
            label2.Text = "Bạn Bè Của Bạn";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 2;
            label1.Text = "Đang Hoạt Động";
            // 
            // panelAllFr
            // 
            panelAllFr.BackColor = Color.Transparent;
            panelAllFr.Location = new Point(0, 297);
            panelAllFr.Margin = new Padding(0, 3, 3, 3);
            panelAllFr.Name = "panelAllFr";
            panelAllFr.Size = new Size(1137, 450);
            panelAllFr.TabIndex = 1;
            // 
            // panelOnl
            // 
            panelOnl.AutoScroll = true;
            panelOnl.BackColor = Color.Transparent;
            panelOnl.Location = new Point(3, 62);
            panelOnl.Name = "panelOnl";
            panelOnl.Size = new Size(1133, 155);
            panelOnl.TabIndex = 0;
            // 
            // panelFr
            // 
            panelFr.Controls.Add(panelAddFr);
            panelFr.Controls.Add(label4);
            panelFr.Controls.Add(label3);
            panelFr.Controls.Add(panelKNN);
            panelFr.Location = new Point(12, 62);
            panelFr.Name = "panelFr";
            panelFr.Size = new Size(1200, 750);
            panelFr.TabIndex = 4;
            // 
            // panelAddFr
            // 
            panelAddFr.Location = new Point(15, 329);
            panelAddFr.Name = "panelAddFr";
            panelAddFr.Size = new Size(1182, 415);
            panelAddFr.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(15, 288);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 2;
            label4.Text = "Kết Bạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.Size = new Size(356, 32);
            label3.TabIndex = 1;
            label3.Text = "Những Người Có Thể Bạn Thích";
            // 
            // panelKNN
            // 
            panelKNN.Location = new Point(9, 63);
            panelKNN.Name = "panelKNN";
            panelKNN.Size = new Size(1191, 204);
            panelKNN.TabIndex = 0;
            // 
            // ClientIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1262, 853);
            Controls.Add(panelFr);
            Controls.Add(panelIndex);
            Controls.Add(buttonFr);
            Controls.Add(buttonIndex);
            Name = "ClientIndex";
            Text = "ClientIndex";
            Load += ClientIndex_Load;
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            panelFr.ResumeLayout(false);
            panelFr.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonIndex;
        private Button buttonFr;
        private Panel panelIndex;
        private Label label2;
        private Label label1;
        private Panel panelAllFr;
        private Panel panelOnl;
        private Panel panelFr;
        private Panel panelAddFr;
        private Label label4;
        private Label label3;
        private Panel panelKNN;
    }
}