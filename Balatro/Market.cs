using Balatro.Jokers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

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
        public static Dictionary<int, List<int>> Jokercoor = new Dictionary<int, List<int>> {
            {1, [440]},
            {2, [365, 515]},
            {3, [290, 440, 590]},
            {4, [215, 365, 515, 665]},
            {5, [140, 290, 440, 590, 740]}
        };
        public static List<Joker> Jokerlist = new List<Joker>()
        {
            {new Lust()},
            {new Greed()},
            {new Wrath()},
            {new Gluttony()},
            {new FinkiStudent()},
            {new Casino()},
            {new Obrok()},
            {new Attorney()},
            {new Anarchy()},
            {new JSP()},
            {new Scholarship()},
            {new Aristocracy()},
            {new Royal()},
            {new Optimist()},
            {new Pessimist()},
            {new Encore()},
            {new Exam()},
            {new Uno()},
            {new Jackpot()},
            {new Lupus()},
            {new VIS()},
            {new Toilet()},
            {new Hitman()},
            {new Fibonacci()},
            {new Spaghetti()},
            {new Psycho()},
            {new Badnik()},
            {new Corruption()},
            {new FinkiZgrada()}
        };

        public static List<Joker> Planetlist = new List<Joker>()
        {
            {new Mercury()},
            {new Pluto()},
            {new Venus()},
            {new Mars()},
            {new Earth()},
            {new Jupiter()},
            {new Saturn()},
            {new Neptune()},
            {new Uranus()}
        };

        List<Joker> MarketJokers = new List<Joker>();
        public static List<Joker> JokersInUse = new List<Joker>();
        int bank { get; set; }

        List<Pack> packs = new List<Pack>()
        {
            new Pack(Image.FromFile(Path.Combine(Application.StartupPath, "Pack-Designs", "buffoon.jpg"))),
            new Pack(Image.FromFile(Path.Combine(Application.StartupPath, "Pack-Designs", "celestial.jpg"))),
        };

        List<Panel> panels = new List<Panel>();


        public Market(Form1 game, int money, int total, GameApplicationContext context)
        {
            InitializeComponent();
            this.game = game;
            this.money = money;
            this.total = total;
            this.bank = money + total;
            MoneyBox.Text = $"${bank}";
            this.context = context;
            panels.Add(panel6);
            panels.Add(panel7);
        }

        public void Testing()
        {
        }

        private async void Market_Load(object sender, EventArgs e)
        {
            LoadJokers();
            JokerPanel.Invalidate();
            timer1.Start();
            await Task.Delay(800);
            timer2.Start();
            Testing();

        }
        public void LoadJokers()
        {

            int x = 95;
            int y = 107;
            int targetx = 40;
            int targety = 30;
            for (int i = 0; i < 2; i++)
            {
                Joker joker = Jokerlist[rnd.Next(0, Jokerlist.Count)];
                Jokerlist.Remove(joker);
                MarketJokers.Add(joker);
                joker.sizex = 0;
                joker.sizey = 0;
                joker.x = x;
                joker.y = y;
                joker.targetx = targetx;
                joker.targety = targety;
                x += 140;
                targetx += 140;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Joker joker in MarketJokers)
            {
                Jokerlist.Add(joker);
            }
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

        public bool PackAppear(Pack pack, Panel panel)
        {
            if (pack.height >= 217 || pack.width >= 133)
            {
                pack.x = 67;
                pack.y = 25;
                pack.height = 217;
                pack.width = 133;
                panel.Invalidate();
                return true;
            }
            else
            {
                pack.x -= 9;
                pack.y -= 15;
                pack.height += 31;
                pack.width += 19;
                panel.Invalidate();
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
            if (!timer1.Enabled && !timer2.Enabled)
            {
                Joker BuyJoker = null;
                foreach (Joker joker in MarketJokers)
                {
                    if (joker.ContainsPoint(e.Location))
                    {
                        JokerInfo infobox = new JokerInfo(joker, true, false, false);
                        infobox.ShowDialog();
                        if (infobox.DialogResult == DialogResult.OK)
                        {
                            if (bank - joker.price < 0)
                            {
                                MessageBox.Show("Немаш доволно пари", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else if (JokersInUse.Count == 5)
                            {
                                MessageBox.Show("Не Смееш да Држиш Повеќе од 5 Џокери", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                joker.targety = 1;
                                JokersInUse.Add(joker);
                                Jokerlist.Remove(joker);
                                JokerPanel.Invalidate();
                                bank -= joker.price;
                                MoneyBox.Text = $"${bank}";
                                BuyJoker = joker;
                                break;
                            }
                            Testing();
                        }
                    }
                }
                if (BuyJoker != null)
                {
                    MarketJokers.Remove(BuyJoker);
                    panel3.Invalidate();
                }
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
                    JokerInfo infobox = new JokerInfo(joker, false, false, false);
                    infobox.ShowDialog();
                    if (infobox.DialogResult == DialogResult.OK)
                    {
                        bank += Math.Max(1, joker.price / 2);
                        MoneyBox.Text = $"${bank}";
                        Jokerlist.Add(joker);
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
                    foreach (Joker joker in MarketJokers)
                    {
                        Jokerlist.Add(joker);
                    }
                    MarketJokers.Clear();
                    bank -= 5;
                    MoneyBox.Text = $"${bank}";
                    LoadJokers();
                    timer1.Start();
                }
                Testing();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            if (packs[0] != null)
            {
                packs[0].DrawCard(e.Graphics);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (currentCard >= 2)
            {
                timer2.Stop();
                currentCard = 0;
                return;
            }
            if (PackAppear(packs[currentCard], panels[currentCard]))
            {
                currentCard++;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            if (packs[1] != null)
            {
                packs[1].DrawCard(e.Graphics);
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled && packs[0] != null)
            {
                if (packs[0].ContainsPoint(e.Location))
                {
                    if (JokersInUse.Count == 5)
                    {
                        MessageBox.Show("Не Смееш да Држиш Повеќе од 5 Џокери", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        JokerInfo packinfo = new JokerInfo(packs[0], false);
                        packinfo.ShowDialog();
                        if (packinfo.DialogResult == DialogResult.OK)
                        {
                            if (bank - 5 < 0)
                            {
                                MessageBox.Show("Немаш доволно пари", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                bank -= 5;
                                MoneyBox.Text = $"${bank.ToString()}";
                                packs[0] = null;
                                panel6.Invalidate();
                                PackForm pack = new PackForm(false);
                                pack.ShowDialog();
                                if (pack.DialogResult == DialogResult.OK)
                                {
                                    pack.Close();
                                    JokerPanel.Invalidate();
                                }
                                Testing();
                            }
                        }
                    }
                }
            }
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled && packs[1] != null)
            {
                if (packs[1].ContainsPoint(e.Location))
                {
                    JokerInfo packinfo = new JokerInfo(packs[1], true);
                    packinfo.ShowDialog();
                    if (packinfo.DialogResult == DialogResult.OK)
                    {
                        if (bank - 5 < 0)
                        {
                            MessageBox.Show("Немаш доволно пари", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            bank -= 5;
                            MoneyBox.Text = $"${bank.ToString()}";
                            packs[1] = null;
                            panel7.Invalidate();
                            PackForm pack = new PackForm(true);
                            pack.ShowDialog();
                            if (pack.DialogResult == DialogResult.OK)
                            {
                                pack.Close();
                            }
                        }
                    }
                }
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Reorder reorder = new Reorder();
            reorder.ShowDialog();
            if (reorder.DialogResult == DialogResult.OK)
            {
                JokerPanel.Invalidate();
            }
        }
    }
}
