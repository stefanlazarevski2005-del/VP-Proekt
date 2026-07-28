using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public class PlayingCard : Card
    {
        public enum znak
        {
            hearts,
            spades,
            clubs,
            diamonds
        }
        public znak suit { get; set; }
        public int number { get; set; }
        public bool isFaceCard { get; set; }
        public bool isSelected { get; set; }
        Image image { get; set; }

        public int points { get; set; }
        public bool isPlayable { get; set; }

        public PlayingCard(znak suit, int number, Image image) : base ()
        {
            this.suit = suit;
            this.number = number;
            this.image = image;
            if (number > 10)
            {
                this.isFaceCard = true;
                this.points = 10;
            }
            else
            {
                this.isFaceCard = false;
                if (number == 1)
                {
                    this.points = 11;
                }
                else
                {
                    this.points = number;
                }
            }
        }



        public override string ToString()
        {
            return $"{suit}, {number}, {points}";
        }
        public override void DrawCard(Graphics g)
        {
            if (isSelected)
            {
                g.DrawImage(image, x, y - 40, 110, 154);
            }
            else
            {
                g.DrawImage(image, x, y, 110, 154);
            }
        }

        public override bool ContainsPoint(Point point)
        {
            Rectangle area;
            if (isSelected)
            {
                area = new Rectangle((int)x, (int)y - 40, 110, 154);
            }
            else
            {
                area = new Rectangle((int)x,(int)y, 110, 154);
            }

            return area.Contains(point);
        }

        public void Click(List<PlayingCard> selected)
        {
            if (!isSelected)
            {
                isSelected = true;
                selected.Add(this);
            }
            else
            {
                isSelected = false;
                selected.Remove(this);
            }
        }
    }
}
