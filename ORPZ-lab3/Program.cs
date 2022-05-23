using System;
using ORPZ_lab3.Decks;
using ORPZ_lab3.FactoryMethod;

namespace ORPZ_lab3
{
    class Program
    {
        private static int GetIntFromUserInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not valid input. Try again.");
                }
            }
        }

        static void Main(string[] args)
        {
            Deck deck = null;
            IDeckCreator deckCreator = null;

            do
            {
                Console.WriteLine("Types of deck:");
                Console.WriteLine("1. Deck based on array.");
                Console.WriteLine("2. Deck based on linked list.");
                Console.Write("Select type of deck: ");
                switch (GetIntFromUserInput())
                {
                    case 1:
                        deckCreator = new ArrayDeckCreator();
                        deck = deckCreator.CreateDeck();
                        break;
                    case 2:
                        deckCreator = new ArrayDeckCreator();
                        deck = deckCreator.CreateDeck();
                        break;
                    default:
                        Console.WriteLine("Please, enter 1 or 2");
                        break;
                }
            } while (deck == null);

            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("List of options: ");
                Console.WriteLine("1. Add a new card to the deck.");
                Console.WriteLine("2. View all cards in the deck.");
                Console.WriteLine("3. Exit");
                Console.Write("Select option: ");
                switch (GetIntFromUserInput())
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Wrong number. Try again.");
                        break;
                }
            }

        }
    }
}