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
            JokerPanel = new Panel();
            button2 = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel9 = new Panel();
            MoneyBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button3 = new Button();
            panel9.SuspendLayout();
            SuspendLayout();
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(815, 314);
            button2.Name = "button2";
            button2.Size = new Size(187, 44);
            button2.TabIndex = 0;
            button2.Text = "Смени Редослед";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button2_MouseClick;
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
            timer1.Interval = 24;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 24;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(245, 339);
            button1.Name = "button1";
            button1.Size = new Size(194, 92);
            button1.TabIndex = 7;
            button1.Text = "Продолжи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(245, 441);
            button3.Name = "button3";
            button3.Size = new Size(194, 92);
            button3.TabIndex = 8;
            button3.Text = "Врти Пак $5";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Market
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Lime;
            ClientSize = new Size(1088, 905);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel9);
            Controls.Add(label1);
            Controls.Add(JokerPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Market";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market";
            Load += Market_Load;
            Paint += Market_Paint;
            MouseDown += Market_MouseDown;
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel JokerPanel;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel9;
        private TextBox MoneyBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}