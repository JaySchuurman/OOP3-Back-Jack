using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Back_Jack
{
    public enum Suits
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues
    {
        ACE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public class Card
    {
        Suits suit;
        FaceValues faceValue;
        int value;
        Image img;

        public Suits Suit { 
            get { 
                return suit; 
                } 
        }
        public int Value
        {
            get { return value; }
            set
            {
                if (faceValue == FaceValues.ACE)
                {
                    this.value = value;
                }
            }
        }

        public Card(Suits suit, FaceValues faceValue)
        {
            this.suit = suit;
            this.value = value;
            switch (faceValue)
            {
                case FaceValues.ACE:
                    this.value = 11;
                    break;
                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)faceValue;
                    break;
            }
        }

        public override string ToString()
        {
            return this.value + "of" + this.suit;
        }
    }
}
