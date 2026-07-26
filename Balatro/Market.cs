using Balatro.Jokers;
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
        GameApplicationContext context;
        Joker test;
        Random rnd = new Random();
        int currentCard = 0;
        public static Dictionary<int, Func<Joker>> JokerHash = new Dictionary<int, Func<Joker>>
        {
            {0, () => new Lust()},
            {1, () => new Greed()},
            {2, () => new Wrath()},
            {3, () => new Gluttony()},
        };
        List<Joker> MarketJokers = new List<Joker>();
        List<string> noDuplicates = new List<string>();


        public Market(Form1 game, int money, int total, GameApplicationContext context)
        {
            InitializeComponent();
            this.game = game;
            this.money = money;
            this.total = total;
            MoneyBox.Text = $"${money + total}";
            this.context = context;
        }

        private void Market_Load(object sender, EventArgs e)
        {
            LoadJokers();
            timer1.Start();
        }
        public void LoadJokers()
        {
            int x = 95;
            int y = 107;
            int targetx = 40;
            int targety = 30;
            for (int i = 0; i < 2; i++)
            {
                Joker joker = JokerHash[rnd.Next(0, JokerHash.Keys.Count)]();
                joker.x = x;
                joker.y = y;
                joker.targetx = targetx;
                joker.targety = targety;
                while (true)
                {
                    if (!noDuplicates.Contains(joker.name))
                    {
                        noDuplicates.Add(joker.name);
                        MarketJokers.Add(joker);
                        break;
                    }
                    else
                    {
                        joker = JokerHash[rnd.Next(0, JokerHash.Keys.Count)]();
                    }
                }
                x += 140;
                targetx += 140;
                listBox1.Items.Add(joker);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            context.ReturnFromMarket(game, money + total);
        }



        public void printCards(PaintEventArgs e)
        {
            foreach (Joker joker in MarketJokers)
            {
                joker.DrawCard(e.Graphics);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            printCards(e);
        }

        public bool CardAppear(Joker joker)
        {
            if (joker.x == joker.targetx || joker.y == joker.targety)
            {
                joker.x = joker.targetx;
                joker.y = joker.targety;
                joker.sizex = 110;
                joker.sizey = 154;
                panel3.Invalidate();
                return true;
            }
            else
            {
                joker.x -= 5;
                joker.y -= 7;
                joker.sizex += 10;
                joker.sizey += 14;
                panel3.Invalidate();
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentCard >= MarketJokers.Count)
            {
                timer1.Stop();
                currentCard = 0;
                return;
            }
            if (CardAppear(MarketJokers[currentCard]))
            {
                currentCard++;
            }
        }

    }
}
