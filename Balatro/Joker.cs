using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public abstract class Joker
    {
        public string title {  get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string tag { get; set; }
        public string desc { get; set; }
        public Image img { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int targetx { get; set; }
        public int targety { get; set; }
        public int sizex { get; set; }
        public int sizey { get; set; }

        public Joker(string title, string name, int price, string tag, string desc) 
        {
            this.title = title;
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

        public bool ContainsPoint(Point point, int x, int y)
        {
            Rectangle area = new Rectangle(x, y, 110, 154);
            return area.Contains(point);
        }
    }
}
