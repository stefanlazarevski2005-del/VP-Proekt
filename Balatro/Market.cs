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
        int currentPack = 0;
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

        int rerollprice = 5;

        List<Pack> packs = new List<Pack>()
        {
            new Pack(Image.FromFile(Path.Combine(Application.StartupPath, "Pack-Designs", "buffoon.jpg"))),
            new Pack(Image.FromFile(Path.Combine(Application.StartupPath, "Pack-Designs", "celestial.jpg"))),
        };



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

        private async void Market_Load(object sender, EventArgs e)
        {
            packs[0].x = 369;
            packs[0].targetx = 302;
            packs[0].y = 692;
            packs[0].targety = 583;
            packs[1].x = 651;
            packs[1].targetx = 584;
            packs[1].y = 692;
            packs[1].targety = 583;
            LoadJokers();
            JokerPanel.Invalidate();
            timer1.Start();
            await Task.Delay(800);
            timer2.Start();

        }
        public void LoadJokers()
        {

            int x = 554;
            int y = 436;
            int targetx = 499;
            int targety = 359;
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

        private void Market_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 220, 314, 579, 526);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), 235, 329, 214, 214);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), 464, 329, 320, 214);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), 235, 558, 267, 267);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), 517, 558, 267, 267);
            printCards(e);
            if (packs[0] != null)
            {
                packs[0].DrawCard(e.Graphics);
            }
            if (packs[1] != null)
            {
                packs[1].DrawCard(e.Graphics);
            }
        }




        public void printCards(PaintEventArgs e)
        {
            foreach (Joker joker in MarketJokers)
            {
                joker.DrawCard(e.Graphics);
            }
        }


        public bool CardAppear(Joker joker)
        {
            if (joker.x == joker.targetx || joker.y == joker.targety)
            {
                joker.x = joker.targetx;
                joker.y = joker.targety;
                joker.sizex = 110;
                joker.sizey = 154;
                Invalidate();
                return true;
            }
            else
            {
                joker.x -= 5;
                joker.y -= 7;
                joker.sizex += 10;
                joker.sizey += 14;
                Invalidate();
                return false;
            }
        }

        public bool PackAppear(Pack pack)
        {
            if (pack.height >= 217 || pack.width >= 133)
            {
                pack.x = pack.targetx;
                pack.y = pack.targety;
                pack.height = 217;
                pack.width = 133;
                Invalidate();
                return true;
            }
            else
            {
                pack.x -= 9;
                pack.y -= 15;
                pack.height += 31;
                pack.width += 19;
                Invalidate();
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


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (currentPack >= packs.Count)
            {
                timer2.Stop();
                currentPack = 0;
                return;
            }
            if (PackAppear(packs[currentPack]))
            {
                currentPack++;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Joker joker in MarketJokers)
            {
                Jokerlist.Add(joker);
            }
            this.Close();
            context.ReturnFromMarket(game, bank);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled)
            {
                if (bank - rerollprice < 0)
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
                    bank -= rerollprice;
                    rerollprice++;
                    button3.Text = $"Врти Пак ${rerollprice}";
                    MoneyBox.Text = $"${bank}";
                    LoadJokers();
                    timer1.Start();
                }
            }
        }

        private void Market_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled && !timer2.Enabled)
            {
                ClickOnJoker(sender, e);
                ClickOnBuffoonPack(sender, e);
                ClickOnPlanetPack(sender, e);
            }
        }

        private void ClickOnJoker(object sender, MouseEventArgs e)
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
                Invalidate();
            }
        }

        private void ClickOnBuffoonPack(object sender, MouseEventArgs e)
        {
            if (packs[0] != null)
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
                                Invalidate();
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


        private void ClickOnPlanetPack(object sender, MouseEventArgs e)
        {
            if (packs[1] != null)
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
                            Invalidate();
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

    }
}
