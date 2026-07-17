using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Balatro
{
    public class Round
    {
        public List<Card> deck { get; set; }
        public List<Card> selected { get; set; }
        public List<Card> hand { get; set; }
        public int points { get; set; }
        public int minimum { get; set; }
        public bool isBoss { get; set; }
        public int hands { get; set; }
        public int discards { get; set;  }
        public int money { get; set; }


        public Round(List<Card> deck, List<Card> selected, List<Card> hand, int points, int minimum, bool isBoss, int hands, int discards, int money)
        {
            this.deck = deck;
            this.selected = selected;
            this.hand = hand;
            this.points = points;
            this.minimum = minimum;
            this.isBoss = isBoss;
            this.hands = hands;
            this.discards = discards;
            this.money = money;

        }
        void PlayHand(List<Card> selected)
        {

        }

        void DiscardHand(List<Card> selected)
        {

        }

    }
}
