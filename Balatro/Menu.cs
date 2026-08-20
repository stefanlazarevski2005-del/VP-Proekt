using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Menu : Form
    {
        Form1 form;
        public Menu(Form1 form)
        {
            InitializeComponent();
            this.form = form;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ќе го изгубите вашиот прогрес, дали сте сигурни?", "Рестарт", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Save save = new Save();
            save.ShowDialog();
            if (save.DialogResult == DialogResult.No) 
            {
                this.Close();
                form.Close();
            }
        }
    }
}
