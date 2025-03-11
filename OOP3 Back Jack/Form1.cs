using OOP3_Back_Jack.Classes;

namespace OOP3_Back_Jack
{
    public partial class Form1 : Form
    {
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(twoOfHearts.ToString());
            Console.WriteLine(twoOfHearts.Value);
            twoOfHearts.Value = 3;
            Console.WriteLine(twoOfHearts.Value);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
