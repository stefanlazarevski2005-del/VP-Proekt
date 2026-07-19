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
        int numofCards = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
                listBox1.Items.Add($"{round.selected[i]} TargetX: {round.selected[i].targetx} - X: {round.selected[i].x}");
            }
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
                            HandBox.Text = round.CalculateHand();
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
                isAnimationComplete = true;
                return;

            }
            Card karta = round.hand[currentCard];
            float dx = karta.targetx - karta.x;
            float dy = karta.targety - karta.y;
            if (Math.Abs(dx) > 1 || Math.Abs(dy) > 1)
            {
                karta.x += dx * 0.6f;
                karta.y += dy * 0.6f;
                Invalidate();
            }
            else
            {
                karta.x = karta.targetx;
                karta.y = karta.targety;
                currentCard++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (round.selected.Count != 0 && round.discards != 0)
            {
                currentCard = 0;
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
            foreach (Card karta in round.selected) {
                if ((karta.x + 30 < karta.targetx) || (karta.y - 30 > karta.targety))
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
                TestCards();
                round.DiscardHand();
                round.LoadHand();
                timer1.Start();
                round.selected.Clear();
                isAnimationComplete = true;
                return;
            }
        }
    }
}
