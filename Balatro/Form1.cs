using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Balatro
{
    public partial class Form1 : Form
    {
        public static int Count = 0;
        List<int> Blinds = new List<int>() { 5, 5, 5, 5, 5, 5, 2000, 3000, 4000, 5000, 7500, 10000, 12500, 15000, 17500, 20000, 25000, 30000, 40000, 50000, 75000, 100000 };
        List<PlayingCard> Deck = new List<PlayingCard>();
        Round round;
        int currentCard = 0;
        int scoreCard = 0;
        bool moveUp = true;
        Image deck = Image.FromFile("C:\\Users\\Nikola\\Desktop\\VP-proekt\\Proekt\\Balatro\\Deck Design\\card back blue.png");
        Random random = new Random();
        int score;
        int points = 0;
        int counter = 0;
        bool isFinished = false;
        GameApplicationContext context;

        public static Dictionary<string, Score> handScores = new Dictionary<string, Score>
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

        List<Joker> BeforeRoundJokers = new List<Joker>();

        public Form1(int money, GameApplicationContext context)
        {
            this.context = context;
            LoadGame(money);
        }

        public Form1(int money)
        {
            LoadGame(money);
        }

        public void LoadGame(int money)
        {
            InitializeComponent();
            GenerateDeck();
            ShuffleDeck();
            round = new Round(Deck, 0, Blinds[Count], false, 4, 3, money);
            foreach (Joker joker in Market.JokersInUse)
            {
                if (joker.BeforeRound)
                {
                    BeforeRoundJokers.Add(joker);
                }
            }
            MinimumBox.Text = Blinds[Count].ToString();
            Handsbox.Text = round.hands.ToString();
            DiscardBox.Text = round.discards.ToString();
            MoneyBox.Text = $"${round.money.ToString()}";
        }

        public void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    string file = $"C:/Users/Nikola/Desktop/VP-proekt/Proekt/Balatro/PNG-cards-1.3/{NumbertoName(j)}_of_{(PlayingCard.znak)i}.png";
                    Image image = Image.FromFile(file);
                    PlayingCard karta = new PlayingCard((PlayingCard.znak)i, j, image);
                    karta.x = 1282;
                    karta.y = 575;
                    Deck.Add(karta);
                }
            }
        }

        public void ShuffleDeck()
        {
            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                PlayingCard temp = Deck[i];
                Deck[i] = Deck[j];
                Deck[j] = temp;
            }
        }

        public string NumbertoName(int number)
        {
            if (number == 11)
                return "jack";

            if (number == 12)
                return "queen";

            if (number == 13)
                return "king";

            if (number == 1)
                return "ace";

            return number.ToString();
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
            //For Debugging
        }

        public bool Lock()
        {
            return !timer1.Enabled && !timer2.Enabled && !timer3.Enabled && !timer4.Enabled && (isFinished == false);
        }

        public List<PlayingCard> GetSelectedCards(List<PlayingCard> hand)
        {
            List<PlayingCard> selected = new List<PlayingCard>();
            foreach (PlayingCard karta in hand)
            {
                if (karta.isSelected)
                {
                    selected.Add(karta);
                    if (karta.isPlayable)
                    {
                        round.playable.Add(karta);
                    }
                }
            }
            return selected;
        }

        public void UpdataUI()
        {
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
            score = int.Parse(ChipBox.Text);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            printHand(e);
        }

        public void printHand(PaintEventArgs e)
        {
            for (int i = 0; i < round.hand.Count; i++)
            {
                round.hand[i].DrawCard(e.Graphics);
            }
            e.Graphics.DrawImage(deck, 1282, 575, 110, 154);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Lock())
            {
                foreach (PlayingCard karta in round.hand)
                {
                    if (karta.ContainsPoint(e.Location))
                    {
                        if (round.selected.Count < 5 || karta.isSelected)
                        {
                            karta.Click(round.selected);
                            UpdataUI();
                        }
                        Invalidate();
                        break;
                    }
                }
            }
        }

        public bool AnimateOneCard(PlayingCard karta)
        {
            float dx = karta.targetx - karta.x;
            float dy = karta.targety - karta.y;

            if (Math.Abs(dx) > 1 || Math.Abs(dy) > 1)
            {
                karta.x += dx * 0.6f;
                karta.y += dy * 0.6f;
                Invalidate();
                return false;
            }
            else
            {
                karta.x = karta.targetx;
                karta.y = karta.targety;
                return true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentCard >= round.hand.Count)
            {
                timer1.Stop();
                currentCard = 0;
                if (round.selected.Count != 0)
                {
                    foreach (Card karta1 in round.playable)
                    {
                        karta1.targety -= 20;
                    }
                    timer3.Start();
                }
                return;
            }
            PlayingCard karta = round.hand[currentCard];
            if (AnimateOneCard(karta))
            {
                currentCard++;
            }
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            if (Lock() && round.selected.Count != 0 && round.discards != 0)
            {
                round.discards--;
                DiscardBox.Text = round.discards.ToString();
                round.selected.Clear();
                round.selected = GetSelectedCards(round.hand);
                TestCards();
                foreach (PlayingCard karta in round.selected)
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
            bool finished = true;

            foreach (PlayingCard karta in round.selected)
            {
                if ((karta.x + 200 < karta.targetx) ||
                  (karta.y - 40 > karta.targety))
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
                round.playable.Clear();
                currentCard = 0;
                UpdataUI();
                return;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (Lock() && round.selected.Count != 0 && round.hands != 0)
            {
                round.hands--;
                Handsbox.Text = round.hands.ToString();
                round.selected.Clear();
                round.selected = GetSelectedCards(round.hand);
                TestCards();
                Handsbox.Text = round.hands.ToString();
                List<int> playcoor = round.playXcoor[round.selected.Count];
                currentCard = 0;
                for (int i = 0; i < round.selected.Count; i++)
                {
                    round.selected[i].targetx = playcoor[i];
                    round.selected[i].targety = 321;

                    if (!round.selected[i].isPlayable)
                    {
                        round.selected[i].targety += 30;
                    }
                }
                timer1.Start();
                Invalidate();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (scoreCard >= round.playable.Count)
            {
                timer3.Stop();
                scoreCard = 0;
                foreach (PlayingCard karta1 in round.selected)
                {
                    karta1.targetx = 1450;
                    karta1.targety = 200;
                }
                score = int.Parse(ChipBox.Text) * int.Parse(MultBox.Text);
                HandBox.Text = score.ToString();
                timer4.Start();
                return;
            }
            PlayingCard karta = round.playable[scoreCard];
            ChipBox.Text = $"+{karta.points}";
            if (moveUp)
            {
                if (AnimateOneCard(karta))
                {
                    karta.targety = 321;
                    moveUp = false;
                }
            }
            else
            {
                if (AnimateOneCard(karta))
                {
                    moveUp = true;
                    score += karta.points;
                    ChipBox.Text = score.ToString();
                    scoreCard++;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (counter <= score)
            {
                ScoreBox.Text = (points + counter).ToString();
                counter += 2;
            }
            else
            {
                points += score;
                ScoreBox.Text = points.ToString();
                timer4.Stop();
                if (points >= Blinds[Count])
                {
                    isFinished = true;
                    Money moneyform = new Money(this, round.money, round.hands, context);
                    moneyform.ShowDialog();
                    Count++;
                    timer2.Stop();
                    return;
                }
                timer2.Start();
                counter = 0;
                return;
            }
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                HandIndex window = new HandIndex(handScores);
                window.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Market.JokersInUse.Count; i++)
            {
                Market.JokersInUse[i].x = Market.Jokercoor[Market.JokersInUse.Count][i];
                Market.JokersInUse[i].y = 21;
                e.Graphics.DrawImage(Market.JokersInUse[i].img, Market.JokersInUse[i].x, Market.JokersInUse[i].y, 110, 154);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lock())
            {
                Reorder reorder = new Reorder();
                reorder.ShowDialog();
                if (reorder.DialogResult == DialogResult.OK)
                {
                    panel2.Invalidate();
                }
            }
        }
    }
}
