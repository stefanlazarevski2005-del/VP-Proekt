using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Balatro
{
    public partial class PackForm : Form
    {
        bool isPlanet { get; set; }
        Market market { get; set; }
        Random rnd = new Random();
        List<Joker> jokers = new List<Joker>();
        public PackForm(bool isPlanet, Market market)
        {
            InitializeComponent();
            this.isPlanet = isPlanet;
            this.market = market;
            int x = 175;
            if (isPlanet)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Background-Designs\\space.jpg");

            }
            else
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Background-Designs\\buffoon.jpg");
                for (int i = 0; i < 3; i++)
                {
                    Joker joker = Market.Jokerlist[rnd.Next(0, Market.Jokerlist.Count)];
                    Market.Jokerlist.Remove(joker);
                    joker.price = 0;
                    joker.x = x;
                    joker.y = 252;
                    joker.sizex = 110;
                    joker.sizey = 154;
                    jokers.Add(joker);
                    x += 150;
                }
            }
            Invalidate();
        }

        private void PackForm_Paint(object sender, PaintEventArgs e)
        {
            if (!isPlanet)
            {
                foreach (Joker joker in jokers)
                {
                    joker.DrawCard(e.Graphics);
                }
            }
        }


        private void PackForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Joker joker in jokers)
            {
                if (joker.ContainsPoint(e.Location))
                {
                    JokerInfo infobox = new JokerInfo(joker, true);
                    infobox.ShowDialog();
                    if (infobox.DialogResult == DialogResult.OK)
                    {
                        Market.JokersInUse.Add(joker);
                        foreach (Joker remaining in jokers)
                        {
                            if (remaining != joker)
                            {
                                Market.Jokerlist.Add(remaining);
                            }
                        }
                        this.DialogResult = DialogResult.OK;

                    }
                    break;
                }
            }
        }
    }
}
