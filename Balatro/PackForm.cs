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
        Random rnd = new Random();
        List<Joker> cards = new List<Joker>();
        public PackForm(bool isPlanet)
        {
            InitializeComponent();
            this.isPlanet = isPlanet;
            int x = 175;
            if (isPlanet)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Background-Designs\\space.jpg");
                for (int i = 0; i < 3; i++)
                {
                    Joker planet = Market.Planetlist[rnd.Next(0, Market.Planetlist.Count)];
                    while (true)
                    {
                        if (!cards.Contains(planet))
                        {
                            break;
                        }

                        else
                        {
                            planet = Market.Planetlist[rnd.Next(0, Market.Planetlist.Count)];
                        }
                    }
                    planet.x = x;
                    planet.y = 252;
                    planet.sizex = 110;
                    planet.sizey = 154;
                    cards.Add(planet);
                    x += 150;
                }
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
                    cards.Add(joker);
                    x += 150;
                }
            }
            Invalidate();
        }

        private void PackForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Joker card in cards)
            {
                card.DrawCard(e.Graphics);
            }
        }


        private void PackForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Joker card in cards)
            {
                if (card.ContainsPoint(e.Location))
                {
                    JokerInfo infobox = new JokerInfo(card, true, true);
                    infobox.ShowDialog();
                    if (infobox.DialogResult == DialogResult.OK)
                    {
                        if (!isPlanet)
                        {
                            Market.JokersInUse.Add(card);
                            foreach (Joker remaining in cards)
                            {
                                if (remaining != card)
                                {
                                    Market.Jokerlist.Add(remaining);
                                }
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