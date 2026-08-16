namespace Balatro
{
    partial class Money
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Pobeda = new Label();
            RemainHands = new Label();
            Interest = new Label();
            TotalBox = new Label();
            TotalCount = new Label();
            button1 = new Button();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            JokerBox = new Label();
            Joker = new Label();
            Bar = new Panel();
            timer5 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "Победа:";
            // 
            // label2
            // 
            label2.Location = new Point(15, 157);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(293, 128);
            label2.TabIndex = 1;
            label2.Text = "Камата ($1 за секој $5):\r\nМаксимум $5\r\n\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 105);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 2;
            label3.Text = "Преостанати раце:";
            // 
            // Pobeda
            // 
            Pobeda.AutoSize = true;
            Pobeda.ForeColor = Color.Gold;
            Pobeda.Location = new Point(330, 53);
            Pobeda.Name = "Pobeda";
            Pobeda.Size = new Size(42, 32);
            Pobeda.TabIndex = 4;
            Pobeda.Text = "$3";
            // 
            // RemainHands
            // 
            RemainHands.AutoSize = true;
            RemainHands.ForeColor = Color.Gold;
            RemainHands.Location = new Point(330, 105);
            RemainHands.Name = "RemainHands";
            RemainHands.Size = new Size(42, 32);
            RemainHands.TabIndex = 5;
            RemainHands.Text = "$0";
            // 
            // Interest
            // 
            Interest.AutoSize = true;
            Interest.ForeColor = Color.Gold;
            Interest.Location = new Point(330, 157);
            Interest.Name = "Interest";
            Interest.Size = new Size(42, 32);
            Interest.TabIndex = 6;
            Interest.Text = "$0";
            // 
            // TotalBox
            // 
            TotalBox.AutoSize = true;
            TotalBox.Location = new Point(15, 273);
            TotalBox.Margin = new Padding(6, 0, 6, 0);
            TotalBox.Name = "TotalBox";
            TotalBox.Size = new Size(86, 32);
            TotalBox.TabIndex = 7;
            TotalBox.Text = "Тотал:";
            // 
            // TotalCount
            // 
            TotalCount.AutoSize = true;
            TotalCount.ForeColor = Color.Gold;
            TotalCount.Location = new Point(330, 273);
            TotalCount.Name = "TotalCount";
            TotalCount.Size = new Size(42, 32);
            TotalCount.TabIndex = 8;
            TotalCount.Text = "$0";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 323);
            button1.Name = "button1";
            button1.Size = new Size(360, 49);
            button1.TabIndex = 9;
            button1.Text = "Продолжи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(132, 5);
            label9.Name = "label9";
            label9.Size = new Size(136, 40);
            label9.TabIndex = 10;
            label9.Text = "Победи!";
            // 
            // timer1
            // 
            timer1.Interval = 80;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 80;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 80;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 80;
            timer4.Tick += timer4_Tick;
            // 
            // JokerBox
            // 
            JokerBox.AutoSize = true;
            JokerBox.Location = new Point(15, 241);
            JokerBox.Margin = new Padding(6, 0, 6, 0);
            JokerBox.Name = "JokerBox";
            JokerBox.Size = new Size(0, 32);
            JokerBox.TabIndex = 11;
            // 
            // Joker
            // 
            Joker.AutoSize = true;
            Joker.ForeColor = Color.Gold;
            Joker.Location = new Point(330, 241);
            Joker.Name = "Joker";
            Joker.Size = new Size(0, 32);
            Joker.TabIndex = 12;
            // 
            // Bar
            // 
            Bar.BackColor = Color.White;
            Bar.Location = new Point(12, 248);
            Bar.Name = "Bar";
            Bar.Size = new Size(360, 5);
            Bar.TabIndex = 3;
            // 
            // timer5
            // 
            timer5.Interval = 80;
            timer5.Tick += timer5_Tick;
            // 
            // Money
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 384);
            ControlBox = false;
            Controls.Add(JokerBox);
            Controls.Add(Joker);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(TotalCount);
            Controls.Add(TotalBox);
            Controls.Add(Interest);
            Controls.Add(RemainHands);
            Controls.Add(Pobeda);
            Controls.Add(Bar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Money";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Money";
            Load += Money_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Pobeda;
        private Label RemainHands;
        private Label Interest;
        private Label TotalBox;
        private Label TotalCount;
        private Button button1;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Label JokerBox;
        private Label Joker;
        private Panel Bar;
        private System.Windows.Forms.Timer timer5;
    }
}