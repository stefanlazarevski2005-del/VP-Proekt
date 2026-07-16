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
        public Image image;

        public Card (znak suit, int number, Image image)
        {
            this.suit = suit;
            this.number = number;
            if (number > 10)
            {
                this.isFaceCard = true;
            }
            else
            {
                this.isFaceCard = false;
            }

            this.image = image;
        }

        public override string ToString()
        {
            return $"{suit}, {number}";
        }

        public void Click()
        {

        }
    }
}
