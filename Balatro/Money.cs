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
        int extramoney;
        List<Joker> moneyjokers = new List<Joker>();
        GameApplicationContext context;

        public Money(Form1 game, int money, int hands, GameApplicationContext context, int extramoney)
        {
            InitializeComponent();
            this.game = game;
            this.money = money;
            this.hands = hands;
            this.total = 3 + hands + extramoney;
            if (money / 5 > 5)
            {
                this.total += 5;
            }
            else
            {
                this.total += money / 5;
            }
            if (total > 20)
            {
                timer4.Interval = 40;
            }
            this.context = context;
            this.extramoney = extramoney;
            if (extramoney > 10)
            {
                timer5.Interval = 40;
            }
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
            if (counter <= (money / 5) && counter <= 5)
            {
                Interest.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer3.Stop();
                counter = 0;
                await Task.Delay(200);
                if (extramoney > 0)
                {
                    timer5.Start();
                }
                else
                {
                    timer4.Start();
                }
                return;
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (counter <= total)
            {
                TotalCount.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer4.Stop();
                counter = 0;
                return;
            }
        }

        private async void timer5_Tick(object sender, EventArgs e)
        {
            if (counter <= extramoney)
            {
                Joker.Text = $"${counter}";
                counter++;
            }
            else
            {
                timer5.Stop();
                counter = 0;
                await Task.Delay (200);
                timer4.Start();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled && !timer3.Enabled && !timer4.Enabled)
            {
                game.Hide();
                this.Hide();
                Market market = new Market(game, money, total, context);
                market.Show();
                this.Close();
            }
        }

        private void Money_Load(object sender, EventArgs e)
        {
            if (extramoney > 0)
            {
                int offset = 40;
                JokerBox.Text = "Џокер:";
                Joker.Text = "$0";
                Bar.Location = new Point(Bar.Location.X, Bar.Location.Y + offset);
                TotalBox.Location = new Point(TotalBox.Location.X, TotalBox.Location.Y + offset);
                TotalCount.Location = new Point(TotalCount.Location.X, TotalCount.Location.Y + offset);
                button1.Location = new Point(button1.Location.X, button1.Location.Y + offset);
                this.Height += offset;
            }
        }

    }
}
