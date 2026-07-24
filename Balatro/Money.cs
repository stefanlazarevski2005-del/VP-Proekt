using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Money : Form
    {
        Form1 game;
        int money;
        int hands;
        int total;
        int counter = 0;

        public Money(Form1 game, int money, int hands)
        {
            InitializeComponent();
            this.game = game;
            this.money = money;
            this.hands = hands;
            this.total = 3 + hands + (money / 5);
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (counter <= 3)
            {
                Pobeda.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer1.Stop();
                counter = 0;
                await Task.Delay(200);
                timer2.Start();
                return;
            }
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            if (counter <= hands)
            {
                RemainHands.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer2.Stop();
                counter = 0;
                await Task.Delay(200);
                timer3.Start();
                return;
            }
        }

        private async void timer3_Tick(object sender, EventArgs e)
        {
            if (counter <= (money / 5))
            {
                Interest.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer3.Stop();
                counter = 0;
                await Task.Delay(200);
                timer4.Start();
                return;
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (counter <= total)
            {
                Total.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer4.Stop();
                counter = 0;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled && !timer3.Enabled && !timer4.Enabled)
            {
                Market market = new Market(game, money, total);
                market.Show();
                game.Hide();
                this.Close();
            }
        }
    }
}
