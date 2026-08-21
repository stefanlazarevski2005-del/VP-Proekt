using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Lose : Form
    {
        Form1 form;
        public Lose(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Restart();
        }
    }
}
