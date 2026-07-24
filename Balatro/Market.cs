using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Market : Form
    {
        Form1 game;
        int money;
        int total;
        public Market(Form1 game, int money, int total)
        {
            this.game = game;
            this.money = money;
            this.total = total;
            InitializeComponent();
            MoneyBox.Text = $"${money + total}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newgame = new Form1(money+total);
            newgame.Show();
            this.Close();
            game.Dispose();  
        }
    }
}
