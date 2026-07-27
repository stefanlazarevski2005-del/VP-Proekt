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
        public JokerInfo(Joker joker, bool BuyJoker)
        {
            this.joker = joker;
            InitializeComponent();
            TitleBox.Text = joker.title;
            TagBox.Text = $"\"{joker.tag}\"";
            EffectBox.Text = joker.desc;
            img = joker.img;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 25, 25, 110, 154);
        }

 

        private void BuyOrSell_Click(object sender, EventArgs e)
        {
            if (Market.JokersInUse.Count == 5)
            {
                MessageBox.Show("Не Смееш да Држиш Повеќе од 5 Џокери", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
