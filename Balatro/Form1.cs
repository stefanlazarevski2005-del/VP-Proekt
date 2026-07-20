using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Balatro
{
    public partial class Form1 : Form
    {
        List<Card> Deck = new List<Card>();
        Round round;
        bool isAnimationComplete = true;
        int currentCard = 0;
        Image deck;
        Random random = new Random();
        int deckcount = 52;
        public Dictionary<string, Score> handScores = new Dictionary<string, Score>
        {
            { "High Card", new Score(5, 1) },
            { "Pair", new Score(10, 2) },
            { "Two Pair", new Score(20, 2) },
            { "Three of a Kind", new Score(30, 3) },
            { "Straight ", new Score(30, 4) },
            { "Flush", new Score(35, 4) },
            { "Full House", new Score(40, 4) },
            { "Four of a Kind", new Score(60, 7) },
            { "Straight Flush", new Score(100, 8) },
            { "Royal Flush", new Score(100, 8) }
        };


        public Form1()
        {
            InitializeComponent();
            GenerateDeck();
            ShuffleDeck();
            round = new Round(Deck, 0, 300, false, 4, 3, 4);
            deck = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Deck Design\\card back blue.png");
        }

        public void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    string file = $"C:/Users/Nikola/Desktop/VP-proekt/Proekt/Balatro/PNG-cards-1.3/{NumbertoName(j)}_of_{(Card.znak)i}.png";
                    Image image = Image.FromFile(file);
                    Card karta = new Card((Card.znak)i, j, image);
                    Deck.Add(karta);
                }
            }
        }

        public void ShuffleDeck()
        {
            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = Deck[i];
                Deck[i] = Deck[j];
                Deck[j] = temp;
            }
        }
        public string NumbertoName(int number)
        {
            if (number == 11)
            {
                return "jack";
            }
            if (number == 12)
            {
                return "queen";
            }
            if (number == 13)
            {
                return "king";
            }
            if (number == 1)
            {
                return "ace";
            }
            else
            {
                return number.ToString();
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            round.LoadHand();
            await Task.Delay(500);
            timer1.Start();
            Invalidate();
        }
        public void TestCards()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < round.selected.Count; i++)
            {
                listBox1.Items.Add($"{round.selected[i]} Index: {i}");
            }
        }

        public List<Card> GetSelectedCards (List<Card> hand)
        {
            List<Card> selected = new List<Card>();
            foreach (Card karta in hand)
            {
                if (karta.isSelected)
                {
                    selected.Add(karta);
                }
            }
            return selected;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            printHand(e);
        }

        public void printHand(PaintEventArgs e)
        {
            for (int i = 0; i < round.hand.Count; i++)
            {
                {
                    round.hand[i].DrawCard(e.Graphics, (int)round.hand[i].x, (int)round.hand[i].y);
                }
            }
            //Neefikasno
            e.Graphics.DrawImage(deck, 1282, 575, 110, 154);
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isAnimationComplete)
            {
                foreach (Card karta in round.hand)
                {
                    if (karta.ContainsPoint(e.Location, (int)karta.x, (int)karta.y))
                    {
                        if (round.selected.Count < 5 || karta.isSelected)
                        {
                            karta.Click();
                            string hand = round.CalculateHand();
                            HandBox.Text = hand;
                            if (handScores.ContainsKey(hand))
                            {
                                ChipBox.Text = handScores[hand].chips.ToString();
                                MultBox.Text = handScores[hand].mult.ToString();
                            }
                            else
                            {
                                ChipBox.Text = "0";
                                MultBox.Text = "0";
                            }
                        }
                        Invalidate();
                        break;
                    }
                }
            }
        }

        public void AnimateOneCard(System.Windows.Forms.Timer timer, List<Card> cards)
        {
            isAnimationComplete = false;
            if (currentCard >= cards.Count)
            {
                timer.Stop();
                isAnimationComplete = true;
                currentCard = 0;
                return;

            }
            Card karta = cards[currentCard];
            float dx = karta.targetx - karta.x;
            float dy = karta.targety - karta.y;
            if (Math.Abs(dx) > 1 || Math.Abs(dy) > 1)
            {
                karta.x += dx * 0.5f;
                karta.y += dy * 0.5f;
                Invalidate();
            }
            else
            {
                //deckcount--;
                //DeckCount.Text = $"{deckcount}/52";
                karta.x = karta.targetx;
                karta.y = karta.targety;
                currentCard++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnimateOneCard(timer1, round.hand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            round.selected = GetSelectedCards(round.hand);
            TestCards();
            if (round.selected.Count != 0 && round.discards != 0)
            {
                foreach (Card karta in round.selected)
                {
                    karta.targetx = 1450;
                    karta.targety = 200;
                }
                timer2.Start();
                Invalidate();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            isAnimationComplete = false;
            bool finished = true;
            foreach (Card karta in round.selected)
            {
                if ((karta.x + 200 < karta.targetx) || (karta.y - 40 > karta.targety))
                {
                    karta.x += 200;
                    karta.y -= 40;
                    finished = false;
                    Invalidate();
                }
                else
                {
                    karta.x = karta.targetx;
                    karta.y = karta.targety;
                }
            }
            if (finished)
            {
                timer2.Stop();
                round.DiscardHand();
                round.LoadHand();
                timer1.Start();
                round.selected.Clear();
                currentCard = 0;
                isAnimationComplete = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            round.selected = GetSelectedCards(round.hand);
            TestCards();
            if (round.selected.Count != 0 && round.hands != 0)
            {
                List<int> playcoor = round.playXcoor[round.selected.Count];
                currentCard = 0;
                for (int i = 0; i < round.selected.Count; i++)
                {
                    round.selected[i].targetx = playcoor[i];
                    round.selected[i].targety = 321;
                }
                timer3.Start();
                Invalidate();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            AnimateOneCard(timer3, round.selected);
            if (isAnimationComplete)
            {
                foreach (Card karta in round.selected)
                {
                    karta.targetx = 1450;
                    karta.targety = 200;
                }
                timer2.Start();
            }
        }
    }
}
