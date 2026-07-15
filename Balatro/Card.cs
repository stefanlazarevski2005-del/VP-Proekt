using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{

  
    public class Card
    { 
        public enum znak
        {
            Heart,
            Spade,
            Clover,
            Diamond
        }
        znak suit { get; set; }
        int number { get; set; }
        bool isFaceCard { get; set; }


        public Card (znak suit, int number)
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
        }

        public override string ToString()
        {
            return $"{suit}, {number}";
        }
    }
}
