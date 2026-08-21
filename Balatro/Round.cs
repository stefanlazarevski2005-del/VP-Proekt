using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Balatro
{
    public class Round
    {
        public List<PlayingCard> deck { get; set; }
        public List<PlayingCard> selected { get; set; }
        public List<PlayingCard> hand { get; set; }
        public List<PlayingCard> playable {  get; set; }
        public int points { get; set; }
        public int minimum { get; set; }
        public bool isBoss { get; set; }
        public int hands { get; set; }
        public int discards { get; set;  }
        public int money { get; set; }
        public int handsize {  get; set; }

        public List<int> handXcoor = [318, 434, 550, 666, 782, 898, 1014, 1130];
        public Dictionary<int, List<int>> playXcoor = new Dictionary<int, List<int>>
        {
            {1, [722] },
            {2, [646, 786] },
            {3, [572, 722, 872] },
            {4, [506, 646, 786, 926] },
            {5, [422, 572, 722, 872, 1022] },
        };

        public Round(List<PlayingCard> deck, int points, int minimum, bool isBoss, int hands, int discards, int money)
        {
            this.deck = deck;
            this.selected = new List<PlayingCard>();
            this.hand = new List<PlayingCard>();
            this.playable = new List<PlayingCard>();
            this.points = points;
            this.minimum = minimum;
            this.isBoss = isBoss;
            this.hands = hands;
            this.discards = discards;
            this.money = money;
            handsize = 8;

        }

        public string CalculateHand()
        {
            if (selected.Count == 0)
            {
                return "";
            }
            bool flush = true;
            bool straight = true;
            if (selected.Count != 5)
            {
                flush = false;
                straight = false;
            }
            string f = "Flush";
            string s = "Straight ";
            string hand = "";
            int rf = 0;
            PlayingCard.znak testsuit = selected[0].suit;
            Dictionary<int, List<PlayingCard>> combinations = new Dictionary<int, List<PlayingCard>>();
            SortCardsbyNumber(selected);
            for (int i = 0; i < selected.Count; i++)
            {
                selected[i].isPlayable = false;
                if (!combinations.ContainsKey(selected[i].number))
                {
                    combinations.Add(selected[i].number, new List<PlayingCard>());
                }
                combinations[selected[i].number].Add(selected[i]);
                if (selected[i].suit != testsuit && flush)
                {
                    flush = false;
                }
                if (i != selected.Count - 1 && straight)
                {
                    if (selected[i].number == 1)
                    {
                        if (selected[i+1].number != 5 && selected[i + 1].number != 13)
                        {
                            straight = false;
                        }
                    }
                    else if (selected[i].number != selected[i+1].number+1)
                    {
                        straight = false;
                    }
                }
                rf += selected[i].points;
            }
            if (straight)
            {
                foreach (PlayingCard karta in selected)
                {
                    karta.isPlayable = true;
                }
                hand = s;
            }
            if (flush)
            {
                foreach (PlayingCard karta in selected)
                {
                    karta.isPlayable = true;
                }
                if (rf == 51)
                {
                    hand = "Royal Flush";
                }
                else
                {
                    hand += f;
                }
            }

            if (hand != "")
            {
                return hand;
            }
            bool three = false;
            bool two = false;
            int counter = 0;
            foreach (int key in combinations.Keys)
            {
                if (combinations[key].Count >= 2)
                {
                    foreach (PlayingCard karta in combinations[key])
                    {
                        karta.isPlayable = true;
                    }
                }
                if (combinations[key].Count == 4)
                {
                    return "Four of a Kind";
                }
                if (combinations[key].Count == 3)
                {
                    three = true;
                    continue;
                }

                if (combinations[key].Count == 2) 
                {
                    two = true;
                    counter++;
                    continue;
                }
            }
            if (three)
            {
                if (two)
                {
                    return "Full House";
                }
                else
                {
                    return "Three of a Kind";
                }
            }
            if (two)
            {
                if (counter == 2)
                {
                    return "Two Pair";
                }
                else
                {
                    return "Pair";
                }
            }
            selected[0].isPlayable = true;
            return "High Card";
            }

        public void SortCardsbyNumber(List<PlayingCard> cards)
        {
            int n = cards.Count;
            bool sort=false;
            while (!sort)
            {
                sort = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (cards[i].points < cards[i + 1].points)
                    {
                        PlayingCard temp = cards[i];
                        cards[i] = cards[i + 1];
                        cards[i + 1] = temp;
                        sort = false;
                    }
                    else if (cards[i].points == cards[i + 1].points)
                    {
                        if (cards[i].number < cards[i + 1].number)
                        {
                            PlayingCard temp = cards[i];
                            cards[i] = cards[i + 1];
                            cards[i + 1] = temp;
                            sort = false;
                        }
                    }
                }
                n--;
            }
        }


        public void SortCardsbySuit(List<PlayingCard> cards)
        {
            int n = cards.Count;
            bool sort = false;
            while (!sort)
            {
                sort = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (cards[i].suit > cards[i+1].suit)
                    {
                        PlayingCard temp = cards[i];
                        cards[i] = cards[i + 1];
                        cards[i + 1] = temp;
                        sort = false;
                    }
                }
            }
            
        }

        public void LoadHand()
        {
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].targetx = handXcoor[i];
                hand[i].targety = 510;
            }

            while (hand.Count < handsize && deck.Count > 0)
            {
                hand.Add(deck[0]);
                int handIndex = hand.Count - 1;
                hand[handIndex].targetx = handXcoor[handIndex];
                hand[handIndex].targety = 510;
                deck.RemoveAt(0);
            }

        }

        public void DiscardHand()
        {
            foreach (PlayingCard karta in selected)
            {
                hand.Remove(karta);
            }
        }   

        public void CalculateScore()
        {
            foreach (PlayingCard karta in selected)
            {
                points += karta.points;
            }
        }

    }
}
