using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Win : Form
    {
        Form1 form;
        public Win(Form1 form)
        {
            InitializeComponent();
            HighScoreBox.Text = Form1.HighScore.ToString();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
