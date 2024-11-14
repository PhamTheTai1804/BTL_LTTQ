namespace Client
{
    partial class GameRPS
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
            label1 = new Label();
            myChoiceLabel = new Label();
            opponentChoiceLabel = new Label();
            resultLabel = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(454, 74);
            label1.TabIndex = 0;
            label1.Text = "Rock Paper Scissors";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // myChoiceLabel
            // 
            myChoiceLabel.AutoSize = true;
            myChoiceLabel.Location = new Point(38, 136);
            myChoiceLabel.Name = "myChoiceLabel";
            myChoiceLabel.Size = new Size(79, 20);
            myChoiceLabel.TabIndex = 1;
            myChoiceLabel.Text = "My choice:";
            // 
            // opponentChoiceLabel
            // 
            opponentChoiceLabel.AutoSize = true;
            opponentChoiceLabel.Location = new Point(38, 181);
            opponentChoiceLabel.Name = "opponentChoiceLabel";
            opponentChoiceLabel.Size = new Size(126, 20);
            opponentChoiceLabel.TabIndex = 2;
            opponentChoiceLabel.Text = "Opponent choice:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(303, 83);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(52, 20);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Result:";
            // 
            // btnRock
            // 
            btnRock.Location = new Point(71, 292);
            btnRock.Name = "btnRock";
            btnRock.RightToLeft = RightToLeft.No;
            btnRock.Size = new Size(139, 75);
            btnRock.TabIndex = 4;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(259, 292);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(139, 75);
            btnPaper.TabIndex = 5;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(466, 292);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(139, 75);
            btnScissors.TabIndex = 6;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // GameRPS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(resultLabel);
            Controls.Add(opponentChoiceLabel);
            Controls.Add(myChoiceLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameRPS";
            Text = "GameRPS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label myChoiceLabel;
        private Label opponentChoiceLabel;
        private Label resultLabel;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
    }
}