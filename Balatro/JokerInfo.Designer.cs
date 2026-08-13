namespace Balatro
{
    partial class JokerInfo
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
            panel1 = new Panel();
            TitleBox = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            textBox2 = new TextBox();
            EffectBox = new TextBox();
            TagBox = new TextBox();
            BuyorSellButton = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(TitleBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 60);
            panel1.TabIndex = 0;
            // 
            // TitleBox
            // 
            TitleBox.BackColor = Color.Black;
            TitleBox.BorderStyle = BorderStyle.None;
            TitleBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBox.ForeColor = Color.White;
            TitleBox.Location = new Point(3, 11);
            TitleBox.Name = "TitleBox";
            TitleBox.ReadOnly = true;
            TitleBox.Size = new Size(469, 39);
            TitleBox.TabIndex = 0;
            TitleBox.Text = "Test";
            TitleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(12, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 204);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(EffectBox);
            panel4.Controls.Add(TagBox);
            panel4.Location = new Point(178, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 204);
            panel4.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(0, 78);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(309, 32);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ефект:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // EffectBox
            // 
            EffectBox.BackColor = Color.Black;
            EffectBox.BorderStyle = BorderStyle.None;
            EffectBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EffectBox.ForeColor = Color.White;
            EffectBox.Location = new Point(-3, 116);
            EffectBox.Multiline = true;
            EffectBox.Name = "EffectBox";
            EffectBox.ReadOnly = true;
            EffectBox.Size = new Size(309, 85);
            EffectBox.TabIndex = 2;
            EffectBox.Text = "+3 Множител за секоја детелина во ваша рака";
            EffectBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TagBox
            // 
            TagBox.BackColor = Color.Black;
            TagBox.BorderStyle = BorderStyle.None;
            TagBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TagBox.ForeColor = Color.White;
            TagBox.Location = new Point(3, 11);
            TagBox.Multiline = true;
            TagBox.Name = "TagBox";
            TagBox.ReadOnly = true;
            TagBox.Size = new Size(309, 74);
            TagBox.TabIndex = 1;
            TagBox.Text = "\"Срце није Камен\"";
            TagBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BuyorSellButton
            // 
            BuyorSellButton.BackColor = Color.Gold;
            BuyorSellButton.FlatStyle = FlatStyle.Flat;
            BuyorSellButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuyorSellButton.Location = new Point(326, 288);
            BuyorSellButton.Name = "BuyorSellButton";
            BuyorSellButton.Size = new Size(158, 37);
            BuyorSellButton.TabIndex = 3;
            BuyorSellButton.UseVisualStyleBackColor = false;
            BuyorSellButton.Click += BuyOrSell_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(178, 288);
            button1.Name = "button1";
            button1.Size = new Size(142, 37);
            button1.TabIndex = 4;
            button1.Text = "Излези";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Exit_Click_1;
            // 
            // JokerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(499, 331);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(BuyorSellButton);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "JokerInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JokerInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private TextBox TitleBox;
        private TextBox TagBox;
        private TextBox EffectBox;
        private TextBox textBox2;
        private Button BuyorSellButton;
        private Button button1;
    }
}