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
        public List<int> handXcoor = [318, 434, 550, 666, 782, 898, 1014, 1130];
        public Dictionary<int, List<int>> playXcoor = new Dictionary<int, List<int>>
        {
            {1, [722] },
            {2, [646, 786] },
            {3, [572, 722, 872] },
            {4, [506, 646, 786, 926] },
            {5, [422, 572, 722, 872, 1022] },
        };

        public Round(List<Card> deck, int points, int minimum, bool isBoss, int hands, int discards, int money)
        {
            this.deck = deck;
            this.selected = new List<Card>();
            this.hand = new List<Card>();
            this.points = points;
            this.minimum = minimum;
            this.isBoss = isBoss;
            this.hands = hands;
            this.discards = discards;
            this.money = money;

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
            Card.znak testsuit = selected[0].suit;
            Dictionary<int, List<Card>> combinations = new Dictionary<int, List<Card>>();
            SortCards(selected);
            for (int i = 0; i < selected.Count; i++)
            {
                selected[i].isPlayable = false;
                if (!combinations.ContainsKey(selected[i].number))
                {
                    combinations.Add(selected[i].number, new List<Card>());
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
                foreach (Card karta in selected)
                {
                    karta.isPlayable = true;
                }
                hand = s;
            }
            if (flush)
            {
                foreach (Card karta in selected)
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
                    foreach (Card karta in combinations[key])
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

        public void SortCards(List<Card> cards)
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
                        Card temp = cards[i];
                        cards[i] = cards[i + 1];
                        cards[i + 1] = temp;
                        sort = false;
                    }
                    else if (cards[i].points == cards[i + 1].points)
                    {
                        if (cards[i].number < cards[i + 1].number)
                        {
                            Card temp = cards[i];
                            cards[i] = cards[i + 1];
                            cards[i + 1] = temp;
                            sort = false;
                        }
                    }
                }
                n--;
            }
        }


        public void LoadHand()
        {
            int n = hand.Count;
            if (n == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (deck.Count != 0)
                    {
                        hand.Add(deck[0]);
                        hand[i].targetx = handXcoor[i];
                        hand[i].targety = 510;
                        deck.Remove(deck[0]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 8 - selected.Count; i++)
                {
                    hand[i].targetx = handXcoor[i];
                }
                for (int i = 8-selected.Count; i < 8; i++)
                {
                    hand.Add(deck[0]);
                    hand[i].targetx = handXcoor[i];
                    hand[i].targety = 510;
                    deck.Remove(deck[0]);
                }
            }
        }

        public void DiscardHand()
        {
            foreach (Card karta in selected)
            {
                hand.Remove(karta);
            }
        }   

        public void CalculateScore()
        {
            foreach (Card karta in selected)
            {
                points += karta.points;
            }
        }

    }
}
