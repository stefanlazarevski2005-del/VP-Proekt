namespace Balatro
{
    partial class Market
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
            panel3 = new Panel();
            panel4 = new Panel();
            RerollButton = new Button();
            button1 = new Button();
            panel5 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            JokerPanel = new Panel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel9 = new Panel();
            MoneyBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Location = new Point(244, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 214);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(RerollButton);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(15, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 214);
            panel4.TabIndex = 1;
            // 
            // RerollButton
            // 
            RerollButton.BackColor = Color.Gold;
            RerollButton.FlatStyle = FlatStyle.Popup;
            RerollButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RerollButton.Location = new Point(10, 112);
            RerollButton.Name = "RerollButton";
            RerollButton.Size = new Size(194, 92);
            RerollButton.TabIndex = 1;
            RerollButton.Text = "Врти Пак $5";
            RerollButton.UseVisualStyleBackColor = false;
            RerollButton.MouseDown += RerollButton_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(194, 92);
            button1.TabIndex = 0;
            button1.Text = "Продолжи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(220, 314);
            panel5.Name = "panel5";
            panel5.Size = new Size(579, 526);
            panel5.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(panel2);
            panel7.Location = new Point(297, 244);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 267);
            panel7.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.Controls.Add(panel1);
            panel6.Location = new Point(15, 244);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 267);
            panel6.TabIndex = 2;
            // 
            // JokerPanel
            // 
            JokerPanel.BackColor = Color.Green;
            JokerPanel.Location = new Point(14, 104);
            JokerPanel.Name = "JokerPanel";
            JokerPanel.Size = new Size(990, 194);
            JokerPanel.TabIndex = 3;
            JokerPanel.Paint += JokerPanel_Paint;
            JokerPanel.MouseDown += JokerPanel_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(382, 1);
            label1.Name = "label1";
            label1.Size = new Size(271, 86);
            label1.TabIndex = 4;
            label1.Text = "Маркет";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(64, 64, 64);
            panel9.Controls.Add(MoneyBox);
            panel9.Location = new Point(15, 314);
            panel9.Name = "panel9";
            panel9.Size = new Size(166, 80);
            panel9.TabIndex = 6;
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
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(60, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 197);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(60, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 197);
            panel2.TabIndex = 1;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1019, 852);
            ControlBox = false;
            Controls.Add(panel9);
            Controls.Add(label1);
            Controls.Add(JokerPanel);
            Controls.Add(panel5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Market";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market";
            Load += Market_Load;
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel JokerPanel;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel9;
        private TextBox MoneyBox;
        private Button RerollButton;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Panel panel1;
    }
}