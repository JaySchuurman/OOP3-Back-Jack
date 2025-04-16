using OOP3_Back_Jack;
using OOP3_Back_Jack.Classes;

namespace OOP3_Back_Jack
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        public Form1()
        {
            InitializeComponent();

            Card card = new Card(Suits.HEARTS, FaceValues.ACE);
            System.Diagnostics.Debug.WriteLine("hi");
            System.Diagnostics.Debug.WriteLine(card.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine(deck.DrawCard().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine(deck.DrawCard().ToString());
        }
    }
}
