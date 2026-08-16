namespace Balatro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            ChipBox = new TextBox();
            HandBox = new TextBox();
            MultBox = new TextBox();
            panel1 = new Panel();
            panel10 = new Panel();
            label7 = new Label();
            textBox10 = new TextBox();
            panel8 = new Panel();
            label6 = new Label();
            textBox9 = new TextBox();
            panel9 = new Panel();
            MinimumBox = new TextBox();
            label5 = new Label();
            IndexButton = new Button();
            panel7 = new Panel();
            MoneyBox = new TextBox();
            panel6 = new Panel();
            label3 = new Label();
            Handsbox = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            DiscardBox = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            ScoreBox = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            PlayButton = new Button();
            DiscardButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            timer5 = new System.Windows.Forms.Timer(components);
            SortNumberButton = new Button();
            panel11 = new Panel();
            label8 = new Label();
            SortSuitButton = new Button();
            timer6 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // ChipBox
            // 
            ChipBox.BackColor = Color.Blue;
            ChipBox.Font = new Font("Segoe UI", 25F);
            ChipBox.ForeColor = Color.White;
            ChipBox.Location = new Point(10, 90);
            ChipBox.Name = "ChipBox";
            ChipBox.ReadOnly = true;
            ChipBox.Size = new Size(95, 52);
            ChipBox.TabIndex = 0;
            ChipBox.Text = "0";
            ChipBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HandBox
            // 
            HandBox.BackColor = Color.Black;
            HandBox.Font = new Font("Segoe UI", 20F);
            HandBox.ForeColor = Color.White;
            HandBox.Location = new Point(10, 15);
            HandBox.Name = "HandBox";
            HandBox.Size = new Size(218, 43);
            HandBox.TabIndex = 2;
            HandBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MultBox
            // 
            MultBox.BackColor = Color.Red;
            MultBox.Font = new Font("Segoe UI", 25F);
            MultBox.ForeColor = Color.White;
            MultBox.Location = new Point(133, 90);
            MultBox.Name = "MultBox";
            MultBox.ReadOnly = true;
            MultBox.Size = new Size(95, 52);
            MultBox.TabIndex = 3;
            MultBox.Text = "0";
            MultBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(IndexButton);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 717);
            panel1.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(64, 64, 64);
            panel10.Controls.Add(label7);
            panel10.Controls.Add(textBox10);
            panel10.Location = new Point(171, 620);
            panel10.Name = "panel10";
            panel10.Size = new Size(80, 80);
            panel10.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 1);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 1;
            label7.Text = "Рунда";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Black;
            textBox10.Font = new Font("Segoe UI", 18.5F, FontStyle.Bold);
            textBox10.ForeColor = Color.White;
            textBox10.Location = new Point(10, 30);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(60, 40);
            textBox10.TabIndex = 0;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(64, 64, 64);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(textBox9);
            panel8.Location = new Point(85, 619);
            panel8.Name = "panel8";
            panel8.Size = new Size(80, 80);
            panel8.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 1);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 1;
            label6.Text = "Тура";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Black;
            textBox9.Font = new Font("Segoe UI", 18.5F, FontStyle.Bold);
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(10, 30);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(60, 40);
            textBox9.TabIndex = 0;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(64, 64, 64);
            panel9.Controls.Add(MinimumBox);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(13, 18);
            panel9.Name = "panel9";
            panel9.Size = new Size(238, 125);
            panel9.TabIndex = 6;
            // 
            // MinimumBox
            // 
            MinimumBox.BackColor = Color.Black;
            MinimumBox.Font = new Font("Segoe UI", 20F);
            MinimumBox.ForeColor = Color.White;
            MinimumBox.Location = new Point(10, 64);
            MinimumBox.Name = "MinimumBox";
            MinimumBox.Size = new Size(218, 43);
            MinimumBox.TabIndex = 1;
            MinimumBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.7F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 15);
            label5.Name = "label5";
            label5.Size = new Size(128, 37);
            label5.TabIndex = 0;
            label5.Text = "Граница";
            // 
            // IndexButton
            // 
            IndexButton.BackColor = Color.Red;
            IndexButton.FlatStyle = FlatStyle.Popup;
            IndexButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IndexButton.ForeColor = Color.White;
            IndexButton.Location = new Point(13, 445);
            IndexButton.Name = "IndexButton";
            IndexButton.Size = new Size(66, 254);
            IndexButton.TabIndex = 5;
            IndexButton.Text = "Индекс на раце";
            IndexButton.UseVisualStyleBackColor = false;
            IndexButton.Click += IndexButton_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(MoneyBox);
            panel7.Location = new Point(85, 531);
            panel7.Name = "panel7";
            panel7.Size = new Size(166, 80);
            panel7.TabIndex = 4;
            // 
            // MoneyBox
            // 
            MoneyBox.BackColor = Color.Black;
            MoneyBox.Font = new Font("Segoe UI", 29.5F, FontStyle.Bold);
            MoneyBox.ForeColor = Color.Gold;
            MoneyBox.Location = new Point(11, 10);
            MoneyBox.Name = "MoneyBox";
            MoneyBox.Size = new Size(145, 60);
            MoneyBox.TabIndex = 1;
            MoneyBox.Text = "$15";
            MoneyBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(Handsbox);
            panel6.Location = new Point(85, 445);
            panel6.Name = "panel6";
            panel6.Size = new Size(80, 80);
            panel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 1);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 1;
            label3.Text = "Раце";
            // 
            // Handsbox
            // 
            Handsbox.BackColor = Color.Black;
            Handsbox.Font = new Font("Segoe UI", 18.5F, FontStyle.Bold);
            Handsbox.ForeColor = Color.RoyalBlue;
            Handsbox.Location = new Point(10, 30);
            Handsbox.Name = "Handsbox";
            Handsbox.Size = new Size(60, 40);
            Handsbox.TabIndex = 0;
            Handsbox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(DiscardBox);
            panel5.Location = new Point(171, 445);
            panel5.Name = "panel5";
            panel5.Size = new Size(80, 80);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 6);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 2;
            label4.Text = "Отфрли";
            // 
            // DiscardBox
            // 
            DiscardBox.BackColor = Color.Black;
            DiscardBox.Font = new Font("Segoe UI", 18.5F, FontStyle.Bold);
            DiscardBox.ForeColor = Color.Firebrick;
            DiscardBox.Location = new Point(10, 30);
            DiscardBox.Name = "DiscardBox";
            DiscardBox.Size = new Size(60, 40);
            DiscardBox.TabIndex = 1;
            DiscardBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(ScoreBox);
            panel4.Location = new Point(13, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 95);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 36);
            label2.TabIndex = 1;
            label2.Text = "ПОЕНИ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ScoreBox
            // 
            ScoreBox.BackColor = Color.Black;
            ScoreBox.Font = new Font("Segoe UI", 20F);
            ScoreBox.ForeColor = Color.White;
            ScoreBox.Location = new Point(10, 37);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.Size = new Size(218, 43);
            ScoreBox.TabIndex = 0;
            ScoreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(ChipBox);
            panel3.Controls.Add(HandBox);
            panel3.Controls.Add(MultBox);
            panel3.Location = new Point(13, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 157);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 101);
            label1.Name = "label1";
            label1.Size = new Size(25, 28);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.Blue;
            PlayButton.FlatStyle = FlatStyle.Popup;
            PlayButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayButton.ForeColor = Color.White;
            PlayButton.Location = new Point(449, 685);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(170, 44);
            PlayButton.TabIndex = 6;
            PlayButton.Text = "Играј";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // DiscardButton
            // 
            DiscardButton.BackColor = Color.Red;
            DiscardButton.FlatStyle = FlatStyle.Popup;
            DiscardButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscardButton.ForeColor = Color.White;
            DiscardButton.Location = new Point(939, 685);
            DiscardButton.Name = "DiscardButton";
            DiscardButton.Size = new Size(170, 44);
            DiscardButton.TabIndex = 7;
            DiscardButton.Text = "Отфрли";
            DiscardButton.UseVisualStyleBackColor = false;
            DiscardButton.Click += DiscardButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 16;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 24;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 1;
            timer4.Tick += timer4_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1085, 222);
            button2.Name = "button2";
            button2.Size = new Size(187, 44);
            button2.TabIndex = 1;
            button2.Text = "Смени Редослед";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer5
            // 
            timer5.Interval = 16;
            timer5.Tick += timer5_Tick;
            // 
            // SortNumberButton
            // 
            SortNumberButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SortNumberButton.Location = new Point(7, 7);
            SortNumberButton.Name = "SortNumberButton";
            SortNumberButton.Size = new Size(99, 34);
            SortNumberButton.TabIndex = 8;
            SortNumberButton.Text = "Број";
            SortNumberButton.UseVisualStyleBackColor = true;
            SortNumberButton.Click += SortNumberButton_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gray;
            panel11.Controls.Add(label8);
            panel11.Controls.Add(SortSuitButton);
            panel11.Controls.Add(SortNumberButton);
            panel11.Location = new Point(625, 685);
            panel11.Name = "panel11";
            panel11.Size = new Size(308, 44);
            panel11.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(107, 9);
            label8.Name = "label8";
            label8.Size = new Size(96, 25);
            label8.TabIndex = 13;
            label8.Text = "Сортирај";
            // 
            // SortSuitButton
            // 
            SortSuitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SortSuitButton.Location = new Point(202, 7);
            SortSuitButton.Name = "SortSuitButton";
            SortSuitButton.Size = new Size(99, 34);
            SortSuitButton.TabIndex = 12;
            SortSuitButton.Text = "Знак";
            SortSuitButton.UseVisualStyleBackColor = true;
            SortSuitButton.Click += SortSuitButton_Click;
            // 
            // timer6
            // 
            timer6.Interval = 16;
            timer6.Tick += timer6_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1404, 741);
            Controls.Add(panel11);
            Controls.Add(button2);
            Controls.Add(DiscardButton);
            Controls.Add(PlayButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balatro";
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox HandBox;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private TextBox ScoreBox;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Button IndexButton;
        private TextBox Handsbox;
        private Label label3;
        private Label label4;
        private TextBox DiscardBox;
        private Panel panel9;
        private TextBox MinimumBox;
        private Label label5;
        private Panel panel8;
        private Label label6;
        private TextBox textBox9;
        private Panel panel10;
        private Label label7;
        private TextBox textBox10;
        private Button PlayButton;
        private Button DiscardButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Button button2;
        public TextBox MultBox;
        public TextBox ChipBox;
        private System.Windows.Forms.Timer timer5;
        public TextBox MoneyBox;
        private Button SortNumberButton;
        private Panel panel11;
        private Label label8;
        private Button SortSuitButton;
        private System.Windows.Forms.Timer timer6;
    }
}
