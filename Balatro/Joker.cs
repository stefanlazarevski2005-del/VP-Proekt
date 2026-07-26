using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public abstract class Joker
    {
        public string name { get; set; }
        int price { get; set; }
        string tag { get; set; }
        string desc { get; set; }
        Image img { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int targetx { get; set; }
        public int targety { get; set; }
        public int sizex { get; set; }
        public int sizey { get; set; }

        public Joker(string name, int price, string tag, string desc) 
        {
            this.name = name;
            this.price = price;
            this.tag = tag;
            this.desc = desc;
            this.img = Image.FromFile($"C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Joker-Designs\\{name}.jpg");
            this.x = 0;
            this.y = 0;
            this.targetx = 0;
            this.targety = 0;
            this.sizex = 0;
            this.sizey = 0;
        }

        public abstract void Effect(Round round);

        public void DrawCard(Graphics g)
        {
            g.DrawImage(img, x, y, sizex, sizey);
        }

        public override string ToString()
        {
            return $"{name}, X:{x}, Y:{y}, TargetX:{targetx}, TargetY:{targety}";
        }
    }
}
