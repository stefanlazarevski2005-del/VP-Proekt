using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Balatro
{
    public partial class Form1 : Form
    {
        List<Card> Deck = new List<Card>();
        List<Card> Hand = new List<Card>();
        List<Card> Selected = new List<Card>();
        int points = 0;
        int minimum = 300;
        bool isBoss = false;
        int hands = 4;
        int discards = 3;
        int money = 4;
        Round round;
        bool isAnimationComplete = true;
        int currentCard = 0;
        Image deck;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            GenerateDeck();
            round = new Round(Deck, Selected, Hand, points, minimum, isBoss, hands, discards, money);
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
            int x = 318;
            int y = 510;
            for (int i = 0; i < 8; i++)
            {
                round.hand.Add(round.deck[i]);
                round.deck[i].targetx = x;
                round.deck[i].targety = y;
                x += 116;
            }
            await Task.Delay(500);
            timer1.Start();
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            printHand(e);
        }

        public void printHand(PaintEventArgs e)
        {
            for (int i = 0; i <= currentCard && i < round.hand.Count; i++)
            {
                {
                    round.hand[i].DrawCard(e.Graphics, (int)round.hand[i].x, (int)round.hand[i].y);
                }
            }
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
                            karta.Click(round.selected);
                        }
                        Invalidate();
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isAnimationComplete = false;
            if (currentCard >= round.hand.Count)
            {
                timer1.Stop();
                isAnimationComplete=true;
                return;

            }
            Card karta = round.hand[currentCard];
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
                karta.x = karta.targetx;
                karta.y = karta.targety;
                currentCard++;
            }
        }
    }
}
