namespace Balatro
{
    public partial class Form1 : Form
    {
        List<Card> Deck = new List<Card>();
        public Form1()
        {
            InitializeComponent();
        }

        public void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card karta = new Card((Card.znak)i, j);
                    Deck.Add(karta);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDeck();
        }
    }
}
