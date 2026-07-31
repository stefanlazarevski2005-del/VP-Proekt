using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class JokerInfo : Form
    {
        Image img;
        bool buyJoker;
        Joker joker;
        Pack pack;
        bool isPlanet;
        public JokerInfo(Joker joker, bool BuyJoker)
        { 
            InitializeComponent();
            this.joker = joker;
            TitleBox.Text = joker.title;
            TagBox.Text = $"\"{joker.tag}\"";
            EffectBox.Text = joker.desc;
            this.img = joker.img;
            this.buyJoker = BuyJoker;
            if (buyJoker)
            {
                BuyorSellButton.Text = $"Купи ${joker.price}";
            }
            else
            {
                int resale = Math.Max(1, joker.price / 2);
                BuyorSellButton.Text = $"Продади ${resale}";
            }
        }

        public JokerInfo(Pack pack, bool isPlanet)
        {
            InitializeComponent();
            this.pack = pack;
            this.isPlanet = isPlanet;
            TagBox.Text = "";
            if (isPlanet)
            {

            }
            else
            {
                TitleBox.Text = "Бафун пакет";
                EffectBox.Text = "Бирај 1 од 3 Џокери";
                this.img = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Pack-Designs\\buffoon.jpg");
                BuyorSellButton.Text = "Купи $5";

            }
        }
 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (joker != null)
            {
                e.Graphics.DrawImage(img, 25, 25, 110, 154);
            }
            else
            {
                e.Graphics.DrawImage(img, 23, 9, 114, 186);
            }
        }

 

        private void BuyOrSell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
