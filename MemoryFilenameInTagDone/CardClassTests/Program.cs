using CardClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();

            // Creates a card with the suit and value to make it an Ace of Spades
            Card aS = new Card(1, 1);
            // Creates a card with the suit and value to make it a Queen of Hearts
            Card qH = new Card(12, 3);

            // Calls method to test "is" methods on Ace of Spade card object
            TestCardIsMethods(aS);
            // New line between method calls, for my own need for """"aesthetic"""""
            Console.WriteLine();
            // Calls method to test "is" methods on Queen of Hearts card object
            TestCardIsMethods(qH);
            // New line between method calls, for my own need for """"aesthetic"""""
            Console.WriteLine();
            // Calls method to test properties
            TestProperties();
            // New line between method calls, for my own need for """"aesthetic"""""
            Console.WriteLine();
            // Calls method to test HasMatchingValue()
            TestHasMatchingValue();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestHasMatchingValue()
        {
            Console.WriteLine("Testing HasMatchingValue method.");
            Card aS = new Card(11, 4);
            Card qH = new Card(12, 3);
            Console.WriteLine("Expecting 'The values do not match'.");
            if (aS.HasMatchingValue(qH))
            {
                Console.WriteLine("The values match.");
            }
            else
            {
                Console.WriteLine("The values do not match.");
            }

            Card qC = new Card(12, 1);
            Console.WriteLine("Expecting 'The values match'.");
            if (qC.HasMatchingValue(qH))
            {
                Console.WriteLine("The values match.");
            }
            else
            {
                Console.WriteLine("The values do not match.");
            }
        }

        static void TestProperties()
        {
            Console.WriteLine("Testing properties.");
            Card js = new Card(11, 4);
            string file1 = js.FileName;
            Console.WriteLine("Testing FileName. Expecting cardjd.jpg." + file1);
        }

        static void TestCardConstructors()
        {
            // Calling default and overloaded constructors to create card objects
            Card card1 = new Card();
            Card card2 = new Card(11, 4);

            // Writing lines to the console
            Console.WriteLine("Testing constructors.");
            // Calls ToString method to card objects to test if they match the suit/value expected
            Console.WriteLine("Default constructor. Expecting Ace of Spades. " + card1.ToString());
            Console.WriteLine("Overloaded constructor. Expecting Jack of Diamonds. " + card2.ToString());
            Console.WriteLine();
        }

        static void TestCardIsMethods(Card card)
        {
            // Writing lines to the console
            Console.WriteLine("Testing 'is' methods.");
            // Writes card string to console
            Console.WriteLine("The card is " + card.ToString());

            // Boolean tests for the card, returning a string to the console depending on if each if statement returns t/f
            if (card.IsHeart())
            {
                Console.WriteLine("The card is a heart.");
            }
            else
            {
                Console.WriteLine("The card is not a heart.");
            }

            if (card.IsQueen())
            {
                Console.WriteLine("The card is a queen.");
            }
            else
            {
                Console.WriteLine("The card is not a queen.");
            }

            if (card.IsFaceCard())
            {
                Console.WriteLine("The card is a face card.");
            }
            else
            {
                Console.WriteLine("The card is not a face card.");
            }
        }

    }
}
