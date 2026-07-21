using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{

  
    public class Card
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
        public Image image;
        public float x { get; set; }
        public float y { get; set; }
        public float targetx { get; set; }
        public float targety { get; set; }
        public int points;
        public bool isPlayable { get; set; }

        public Card (znak suit, int number, Image image)
        {
            this.suit = suit;
            this.number = number;
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

            this.image = image;
            this.isSelected = false;
            this.x = 1282;
            this.y = 575;
            this.targetx = 0;
            this.targety = 0;
            this.isPlayable = false;
        }

        public override string ToString()
        {
            return $"{suit}, {number}, {points}";
            ;
        }

        public void DrawCard(Graphics g, int x, int y)
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

        public bool ContainsPoint(Point point, int x, int y)
        {
            Rectangle area;
            if (isSelected)
            {
                area = new Rectangle(x, y-40, 110, 154);
            }
            else
            {
                area = new Rectangle(x, y, 110, 154);
            }

            return area.Contains(point);
        }
        public void Click(List<Card> selected)
        {
            if (!isSelected) { 
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
