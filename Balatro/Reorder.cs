using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class Reorder : Form
    {

        Dictionary<int, List<int>> coor = new Dictionary<int, List<int>>()
        {
            {1, [480]},
            {2, [380, 580]},
            {3, [280, 480, 680]},
            {4, [180, 380, 580, 780]},
            {5, [80, 280, 480, 680, 880]},
        };

        public Reorder()
        {
            InitializeComponent();
            List<Button> buttonlist = new List<Button>()
            {
                {B1},
                {B2},
                {B3},
                {B4},
                {B5},
                {B6},
                {B7},
                {B8},
            };

            if (Market.JokersInUse.Count > 1)
            {
                int counter = 0;
                for (int i = 0; i < Market.JokersInUse.Count - 1; i++)
                {
                    buttonlist[counter].Location = new Point(coor[Market.JokersInUse.Count][i] + 90, 489);
                    buttonlist[counter + 1].Location = new Point(coor[Market.JokersInUse.Count][i + 1], 489);
                    counter += 2;
                }
            }
        }

        private void Reorder_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Market.JokersInUse.Count; i++)
            {
                e.Graphics.DrawImage(Market.JokersInUse[i].img, coor[Market.JokersInUse.Count][i], 275, 140, 196);
            }
        }

        public void MoveRight(int index)
        {
            Joker temp = Market.JokersInUse[index];
            Market.JokersInUse[index] = Market.JokersInUse[index + 1];
            Market.JokersInUse[index + 1] = temp;
            Invalidate();
            //Да нема сина граница околу копчето после кликање
            this.ActiveControl = null;
        }

        public void MoveLeft(int index)
        {
            Joker temp = Market.JokersInUse[index];
            Market.JokersInUse[index] = Market.JokersInUse[index - 1];
            Market.JokersInUse[index - 1] = temp;
            Invalidate();
            this.ActiveControl = null;
        }

        private void B1_MouseClick(object sender, MouseEventArgs e)
        {
            MoveRight(0);
        }

        private void B3_MouseClick(object sender, MouseEventArgs e)
        {
            MoveRight(1);
        }

        private void B5_MouseClick(object sender, MouseEventArgs e)
        {
            MoveRight(2);
        }

        private void B7_MouseClick(object sender, MouseEventArgs e)
        {
            MoveRight(3);
        }

        private void B2_MouseClick(object sender, MouseEventArgs e)
        {
            MoveLeft(1);
        }

        private void B4_MouseClick(object sender, MouseEventArgs e)
        {
            MoveLeft(2);
        }

        private void B6_MouseClick(object sender, MouseEventArgs e)
        {
            MoveLeft(3);
        }

        private void B8_MouseClick(object sender, MouseEventArgs e)
        {
            MoveLeft(4);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Reorder_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
