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
            panel1 = new Panel();
            Pobeda = new Label();
            RemainHands = new Label();
            Interest = new Label();
            label7 = new Label();
            Total = new Label();
            button1 = new Button();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
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
            label2.AutoSize = true;
            label2.Location = new Point(15, 157);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(293, 32);
            label2.TabIndex = 1;
            label2.Text = "Камата ($1 за секој $5):";
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 5);
            panel1.TabIndex = 3;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 234);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 7;
            label7.Text = "Тотал:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.ForeColor = Color.Gold;
            Total.Location = new Point(330, 234);
            Total.Name = "Total";
            Total.Size = new Size(42, 32);
            Total.TabIndex = 8;
            Total.Text = "$0";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 284);
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
            // Money
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 345);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(Total);
            Controls.Add(label7);
            Controls.Add(Interest);
            Controls.Add(RemainHands);
            Controls.Add(Pobeda);
            Controls.Add(panel1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label Pobeda;
        private Label RemainHands;
        private Label Interest;
        private Label label7;
        private Label Total;
        private Button button1;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}