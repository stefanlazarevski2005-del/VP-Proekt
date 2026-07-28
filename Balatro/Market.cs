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
        Dictionary<int, List<int>> Jokercoor = new Dictionary<int, List<int>> {
            {1, [440]},
            {2, [365, 515]},
            {3, [290, 440, 590]},
            {4, [215, 365, 515, 665]},
            {5, [140, 290, 440, 590, 740]}
        };
        public static Dictionary<int, Func<Joker>> JokerHash = new Dictionary<int, Func<Joker>>
        {
            {0, () => new Lust()},
            {1, () => new Greed()},
            {2, () => new Wrath()},
            {3, () => new Gluttony()},
        };
        List<Joker> MarketJokers = new List<Joker>();
        public static List<Joker> JokersInUse = new List<Joker>();
        public static List<string> noDuplicates = new List<string>();
        int bank { get; set; }


        public Market(Form1 game, int money, int total, GameApplicationContext context)
        {
            InitializeComponent();
            this.game = game;
            this.money = money;
            this.total = total;
            this.bank = money + total;
            MoneyBox.Text = $"${bank}";
            this.context = context;
        }

        public void Testing()
        {

        }

        private void Market_Load(object sender, EventArgs e)
        {
            LoadJokers();
            JokerPanel.Invalidate();
            timer1.Start();
        }
        public void LoadJokers()
        {
            foreach (Joker joker in JokersInUse)
            {
                noDuplicates.Add(joker.name);
            }
            int x = 95;
            int y = 107;
            int targetx = 40;
            int targety = 30;
            for (int i = 0; i < 2; i++)
            {
                Joker joker = JokerHash[rnd.Next(0, JokerHash.Keys.Count)]();
                while (true)
                {
                    if (!noDuplicates.Contains(joker.name))
                    {
                        noDuplicates.Add(joker.name);
                        MarketJokers.Add(joker);
                        joker.x = x;
                        joker.y = y;
                        joker.targetx = targetx;
                        joker.targety = targety;
                        break;
                    }
                    else
                    {
                        joker = JokerHash[rnd.Next(0, JokerHash.Keys.Count)]();
                    }
                }
                x += 140;
                targetx += 140;
            }
            noDuplicates.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            context.ReturnFromMarket(game, bank);
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Joker BuyJoker = null;
            foreach (Joker joker in MarketJokers)
            {
                if (joker.ContainsPoint(e.Location))
                {
                    JokerInfo infobox = new JokerInfo(joker, true);
                    infobox.ShowDialog();
                    if (infobox.DialogResult == DialogResult.OK)
                    {
                        if (bank - joker.price < 0)
                        {
                            MessageBox.Show("Немаш доволно пари", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            JokersInUse.Add(joker);
                            JokerPanel.Invalidate();
                            bank -= joker.price;
                            MoneyBox.Text = $"${bank}";
                            BuyJoker = joker;
                            break;
                        }
                    }
                }
            }
            if (BuyJoker != null)
            {
                MarketJokers.Remove(BuyJoker);
                panel3.Invalidate();
            }
        }

        private void JokerPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < JokersInUse.Count; i++)
            {
                JokersInUse[i].x = Jokercoor[JokersInUse.Count][i];
                JokersInUse[i].y = 21;
                e.Graphics.DrawImage(JokersInUse[i].img, JokersInUse[i].x, JokersInUse[i].y, 110, 154);
            }
        }

        private void JokerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Joker SellJoker = null;
            foreach (Joker joker in JokersInUse)
            {
                if (joker.ContainsPoint(e.Location))
                {
                    JokerInfo infobox = new JokerInfo(joker, false);
                    infobox.ShowDialog();
                    if (infobox.DialogResult == DialogResult.OK)
                    {
                        bank += Math.Max(1, joker.price / 2);
                        MoneyBox.Text = $"${bank}";
                        SellJoker = joker;
                        break;
                    }
                }
            }
            if (SellJoker != null)
            {
                JokersInUse.Remove(SellJoker);
                JokerPanel.Invalidate();
            }
        }

        private void RerollButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (bank - 5 < 0)
                {
                    MessageBox.Show("Немаш доволно пари", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MarketJokers.Clear();
                    bank -= 5;
                    MoneyBox.Text = $"${bank}";
                    LoadJokers();
                    timer1.Start();
                }
            }
        }
    }
}
