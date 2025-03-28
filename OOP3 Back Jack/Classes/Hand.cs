using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Back_Jack.Classes
{
    public class Hand
    {
        bool isBust;
        bool isStand;
        List<Card> cards = new List<Card>();

        public void addCard(Card card)
        {
            if (cards.Count < 2 || isBust || isStand)
            {
                return;
            }

            cards.Add(card);

            int total = checkTotal();
            if (total > 21)
            {
               isBust = true;
            }
            else if (total == 21)
            {
                isStand = true;
            }
        }
        
        public int checkTotal()
        {
            int total = 0;

            
            

            return 0;
        }

    }
}
