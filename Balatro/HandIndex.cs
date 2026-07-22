using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Balatro
{
    public partial class HandIndex : Form
    {
        private Dictionary<string, Score> handScores;

        public HandIndex(Dictionary<string, Score> handScores)
        {
            InitializeComponent();
            int i = 0;
            List<TextBox> ChipBoxes = new List<TextBox>() {ChipBox1, ChipBox2, ChipBox3, ChipBox4, ChipBox5, ChipBox6, ChipBox7, ChipBox8, ChipBox9};
            List<TextBox> MultBoxes = new List<TextBox>() { MultBox1, MultBox2, MultBox3, MultBox4, MultBox5, MultBox6, MultBox7, MultBox8, MultBox9 };
            this.handScores = handScores;
            foreach (string key in handScores.Keys)
            {
                if (i==9)
                {
                    break;
                }
                ChipBoxes[i].Text = handScores[key].chips.ToString();
                MultBoxes[i].Text = handScores[key].mult.ToString();
                i++;
            }
        }
    }
}
