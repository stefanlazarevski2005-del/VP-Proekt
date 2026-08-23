namespace Balatro
{
    partial class Win
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            HighScoreBox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 10);
            label1.Name = "label1";
            label1.Size = new Size(460, 65);
            label1.TabIndex = 0;
            label1.Text = "Ја Победи Играта!";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(110, 269);
            button1.Name = "button1";
            button1.Size = new Size(380, 80);
            button1.TabIndex = 2;
            button1.Text = "Почни нова игра";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(110, 355);
            button2.Name = "button2";
            button2.Size = new Size(380, 80);
            button2.TabIndex = 3;
            button2.Text = "Затвори игра";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 143);
            label2.Name = "label2";
            label2.Size = new Size(210, 47);
            label2.TabIndex = 4;
            label2.Text = "High Score:";
            // 
            // HighScoreBox
            // 
            HighScoreBox.AutoSize = true;
            HighScoreBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HighScoreBox.Location = new Point(310, 143);
            HighScoreBox.Name = "HighScoreBox";
            HighScoreBox.Size = new Size(156, 47);
            HighScoreBox.TabIndex = 5;
            HighScoreBox.Text = "Number";
            // 
            // Win
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gold;
            ClientSize = new Size(584, 450);
            ControlBox = false;
            Controls.Add(HighScoreBox);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Win";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label HighScoreBox;
    }
}