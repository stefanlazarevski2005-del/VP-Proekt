using Balatro.Jokers;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Balatro
{
    public partial class Form1 : Form
    {
        public static int Count = 0;
        List<int> Blinds = new List<int>() { 300, 450, 600, 900, 1350, 1800, 2600, 3900, 5200, 8000, 12000, 16000, 20000, 30000, 40000, 54000, 72000, 90000, 120000, 150000 };
        List<PlayingCard> Deck = new List<PlayingCard>();
        Round round;
        public static int currentCard = 0;
        int scoreCard = 0;
        bool moveUp = true;
        Image deck = Image.FromFile(Path.Combine(Application.StartupPath, "Deck Design", "card back blue.png"));
        Random random = new Random();
        public int chips;
        public int mult;
        int score;
        int points = 0;
        int counter = 0;
        bool isFinished = false;
        bool isExecuted = false;
        bool animateJoker = true;
        GameApplicationContext context;
        public int Retriggers = 0;
        public bool isRetrigger = false;
        public bool HitmanLock = true;
        public static List<(PlayingCard.znak suit, int number)> HitmanTargets = new List<(PlayingCard.znak, int)>();
        public int extramoney = 0;

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
        List<Joker> PerCardJokers = new List<Joker>();
        List<Joker> PerHandJokers = new List<Joker>();
        List<Joker> AfterRoundJokers = new List<Joker>();

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
            GetJokerCoor();
            GetJokerOrder();
            foreach (Joker joker in BeforeRoundJokers)
            {
                joker.Effect(round, this);
            }
            MinimumBox.Text = Blinds[Count].ToString();
            Handsbox.Text = round.hands.ToString();
            DiscardBox.Text = round.discards.ToString();
            MoneyBox.Text = $"${round.money.ToString()}";
            Test();
        }

        public void GetJokerCoor()
        {
            foreach (Joker joker in Market.JokersInUse)
            {
                joker.x += 282;
                joker.targetx = joker.x;
                joker.y += 12;
                joker.targety = joker.y - 20;
            }
        }
        public void GetJokerOrder()
        {
            BeforeRoundJokers.Clear();
            PerCardJokers.Clear();
            PerHandJokers.Clear();
            AfterRoundJokers.Clear();
            if (Market.JokersInUse.Any(j => j is FinkiZgrada))
            {
                foreach (Joker joker in Market.JokersInUse)
                {
                    joker.UpdateCopyBehavior();
                }
            }
            foreach (Joker joker in Market.JokersInUse)
            {
                if (joker.BeforeRound)
                {
                    BeforeRoundJokers.Add(joker);
                }
                if (joker.PerCard)
                {
                    PerCardJokers.Add(joker);
                }
                if (joker.PerHand)
                {
                    PerHandJokers.Add(joker);
                }
                if (joker.AfterRound)
                {
                    AfterRoundJokers.Add(joker);
                }
            }
        }

        public void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    string path = Path.Combine(Application.StartupPath, "PNG-cards-1.3", $"{NumbertoName(j)}_of_{(PlayingCard.znak)i}.png");
                    Image image = Image.FromFile(path);
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

        public void Test()
        {

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
            chips = int.Parse(ChipBox.Text);
            mult = int.Parse(MultBox.Text);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            printHand(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGreen), 282, 12, 990, 194);
            printJokers(e);
        }

        public void printHand(PaintEventArgs e)
        {
            for (int i = 0; i < round.hand.Count; i++)
            {
                round.hand[i].DrawCard(e.Graphics);
            }
            e.Graphics.DrawImage(deck, 1282, 575, 110, 154);
        }

        public void printJokers(PaintEventArgs e)
        {
            for (int i = 0; i < Market.JokersInUse.Count; i++)
            {
                Market.JokersInUse[i].targetx = Market.JokersInUse[i].x;
                Market.JokersInUse[i].DrawCard(e.Graphics);
            }
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

        public bool AnimateOneCard(Card karta)
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


        private async void timer3_Tick(object sender, EventArgs e)
        {
            if (currentCard >= round.playable.Count)
            {
                timer3.Stop();
                currentCard = 0;
                foreach (PlayingCard karta1 in round.selected)
                {
                    karta1.targetx = 1450;
                    karta1.targety = 200;
                }
                if (PerHandJokers.Count == 0)
                {
                    score = int.Parse(ChipBox.Text) * int.Parse(MultBox.Text);
                    HandBox.Text = score.ToString();
                    timer4.Start();
                }
                else
                {
                    timer5.Start();
                }
                return;
            }
            PlayingCard karta = round.playable[currentCard];
            if (ScoreWithoutJoker(karta))
            {
                if (counter < PerCardJokers.Count)
                {
                    if (PerCardJokers[counter].Condition(round))
                    {
                        if (animateJoker)
                        {
                            PerCardJokers[counter].Effect(round, this);
                            animateJoker = false;
                        }
                        if (MoveCardUpDown(karta) | MoveCardUpDown(PerCardJokers[counter]))
                        {
                            ChipBox.Text = chips.ToString();
                            MultBox.Text = mult.ToString();
                            counter++;
                            animateJoker = true;
                        }
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    counter = 0;
                    isExecuted = false;
                    if (Retriggers > 0)
                    {
                        Retriggers--;
                        isRetrigger = true;
                    }
                    else
                    {
                        currentCard++;
                        isRetrigger = false;
                    }
                }
            }
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            if (counter <= score)
            {
                ScoreBox.Text = (points + counter).ToString();
                counter += 20;
            }
            else
            {
                points += score;
                ScoreBox.Text = points.ToString();
                timer4.Stop();
                if (points >= Blinds[Count])
                {
                    foreach (Joker joker in AfterRoundJokers)
                    {
                        if (joker.Condition(round))
                        {
                            joker.Effect(round, this);
                        }
                    }
                    isFinished = true;
                    Money moneyform = new Money(this, round.money, round.hands, context, extramoney);
                    moneyform.ShowDialog();
                    Count++;
                    timer2.Stop();
                    return;
                }
                else if (round.hands == 0)
                {
                    Lose lose = new Lose(this);
                    lose.ShowDialog();
                    return;
                }
                timer2.Start();
                counter = 0;
                return;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (counter >= PerHandJokers.Count)
            {
                timer5.Stop();
                score = int.Parse(ChipBox.Text) * int.Parse(MultBox.Text);
                HandBox.Text = score.ToString();
                counter = 0;
                timer4.Start();
                return;
            }
            else
            {
                if (animateJoker)
                {
                    if (!PerHandJokers[counter].Condition(round))
                    {
                        counter++;
                        return;
                    }
                    PerHandJokers[counter].Effect(round, this);
                    animateJoker = false;
                }
                if (MoveCardUpDown(PerHandJokers[counter]))
                {
                    ChipBox.Text = chips.ToString();
                    MultBox.Text = mult.ToString();
                    MoneyBox.Text = $"${round.money}";
                    counter++;
                    animateJoker = true;
                }
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

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            if (Lock() && round.selected.Count != 0 && round.discards != 0)
            {
                if (Market.JokersInUse.OfType<Hitman>().Any() && HitmanLock)
                {
                    foreach (PlayingCard karta in round.selected)
                    {
                        HitmanTargets.Add((karta.suit, karta.number));
                    }
                    HitmanLock = false;
                    round.money += round.selected.Count;
                    MoneyBox.Text = $"${round.money.ToString()}";
                }
                round.discards--;
                DiscardBox.Text = round.discards.ToString();
                round.selected.Clear();
                round.selected = GetSelectedCards(round.hand);
                foreach (PlayingCard karta in round.selected)
                {
                    karta.targetx = 1450;
                    karta.targety = 200;
                }
                timer2.Start();
                Invalidate();
                Test();
            }
        }
        private void IndexButton_Click(object sender, EventArgs e)
        {
            if (!isFinished)
            {
                HandIndex window = new HandIndex(handScores);
                window.ShowDialog();
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
                    int count = Market.JokersInUse.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Joker joker = Market.JokersInUse[i];
                        joker.x = Market.Jokercoor[count][i] + 282;
                    }
                    Invalidate();
                }
                GetJokerOrder();
            }
        }


        public bool MoveCardUpDown(Card karta)
        {
            if (karta.moveUp)
            {
                if (AnimateOneCard(karta))
                {
                    karta.targety += 20;
                    karta.moveUp = false;
                }
                return false;
            }
            else
            {
                if (AnimateOneCard(karta))
                {
                    karta.targety -= 20;
                    karta.moveUp = true;
                    return true;
                }
                return false;
            }
        }

        public bool ScoreWithoutJoker(PlayingCard karta)
        {
            if (isExecuted)
            {
                return isExecuted;
            }
            else
            {
                if (MoveCardUpDown(karta))
                {
                    chips += karta.points;
                    ChipBox.Text = chips.ToString();
                    isExecuted = true;
                    return true;
                }
                else
                {
                    ChipBox.Text = $"+{karta.points}";
                    return false;
                }
            }
        }

        private void SortNumberButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            round.SortCardsbyNumber(round.hand);
            foreach (PlayingCard karta in round.hand)
            {
                karta.targetx = round.handXcoor[i];
                i++;
            }
            timer6.Start();

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            bool finished = true;

            foreach (PlayingCard karta in round.hand)
            {
                if (!AnimateOneCard(karta))
                {
                    finished = false;
                }
            }

            if (finished)
            {
                timer6.Stop();
            }
        }

        private void SortSuitButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            round.SortCardsbySuit(round.hand);
            foreach (PlayingCard karta in round.hand)
            {
                karta.targetx = round.handXcoor[i];
                i++;
            }
            timer6.Start();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (Lock())
            {
                Menu menu = new Menu(this);
                menu.ShowDialog();
            }
        }

        public void Restart()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            currentCard = 0;
            Count = 0;
            Market.JokersInUse.Clear();
            HitmanTargets.Clear();
            context.StartNewRound(4);
            this.Close();
        }
    }
}
