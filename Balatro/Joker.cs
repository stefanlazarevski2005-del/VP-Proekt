using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public abstract class Joker : Card
    {
        public string title {  get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string tag { get; set; }
        public string desc { get; set; }
        public Image img { get; set; }
        public int sizex { get; set; }
        public int sizey { get; set; }

        public bool BeforeRound { get; set; }
        public bool PerCard { get; set; }
        public bool PerHand { get; set; }
        public bool AfterRound { get; set; }
        public Random rnd = new Random();

        public Joker(string title, string name, int price, string tag, string desc) : base()
        {
            this.title = title;
            this.name = name;
            this.price = price;
            this.tag = tag;
            this.desc = desc;
            this.img = Image.FromFile($"C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Joker-Designs\\{name}.jpg");
            this.sizex = 0;
            this.sizey = 0;
            BeforeRound = false;
            PerCard = false;
            PerHand = false;
            AfterRound = false;
        }

        public abstract bool Condition(Round round);

        public abstract void Effect(Round round, Form1 form);

        public abstract void Effect();

        public override void DrawCard(Graphics g)
        {
            g.DrawImage(img, x, y, sizex, sizey);
        }

        public override string ToString()
        {
            return $"{name}";
        }

        public override bool ContainsPoint(Point point)
        {
            Rectangle area = new Rectangle((int)x,(int)y, 110, 154);
            return area.Contains(point);
        }
    }
}
