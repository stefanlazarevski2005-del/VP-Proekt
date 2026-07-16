using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.NetworkInformation;

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
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDeck();
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            printHand(e);
        }

        public void printHand(PaintEventArgs e)
        {
            int x = 318;
            int y = 510;
            for (int i = 0; i < 8; i++)
            {
                e.Graphics.DrawImage(Deck[i].image, x, y, 110, 154);
                x += 116;
            }
        }
    }
}
