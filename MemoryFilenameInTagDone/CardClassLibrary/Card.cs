using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Card
    {
        // The suit can range from 1 to 4
        private int suit;
        private string[] suits = {"????", "spades", "clubs", "hearts", "diamonds"};

        // The value can range from 1 to 13
        private int value;
        private string[] values = {"????", "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"};

        // Default card is ace of spades for default constructor
        public Card()
        {
            suit = 1;
            value = 1;
        }

        // Card with specified value and suit created
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        // Getter/Setter for suit property
        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }

        // Getter/Setter for value property
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        // Method declaration to test if card is queen
        public bool IsQueen()
        {
            if (value == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method declaration to test if card is heart
        public bool IsHeart()
        {
            if (suit == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method declaration to test if card is face card
        public bool IsFaceCard()
        {
            if (value >= 11 && value <= 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method declaration to override output of normal ToString method
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }

    }
}
