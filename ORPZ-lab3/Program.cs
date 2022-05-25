using System;
using ORPZ_lab3.Decks;
using ORPZ_lab3.FactoryMethod;

namespace ORPZ_lab3
{
    // Потрібно розробити програму, яка вміє правильно додавати нову карту в
    // колоду гральних карт. Особливістю програми є те, що колода може бути
    // заснована на двох колекціях (зв'язний список і масив), які потрібно
    // реалізувати самостійно.
    public static class Program
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

        static void Main()
        {
            Deck deck = null;

            do
            {
                IDeckCreator deckCreator;
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
                        deckCreator = new ListDeckCreator();
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
                        AddCardToDeck(deck);
                        break;
                    case 2:
                        ViewAllCards(deck);
                        break;
                    case 3:
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Wrong number. Try again.");
                        break;
                }
            }

        }

        private static void AddCardToDeck(Deck deck)
        {
            try
            {
                Console.WriteLine("List of possible suits: ");
                Console.WriteLine("1. Clubs");
                Console.WriteLine("2. Diamonds");
                Console.WriteLine("3. Hearts");
                Console.WriteLine("4. Spades");
                Console.Write("Select suit: ");
                var suitNum = GetIntFromUserInput();

                Console.WriteLine();
                Console.WriteLine("List of possible values: ");
                Console.WriteLine("1. Ace");
                Console.WriteLine("2. '2'");
                Console.WriteLine("3. '3'");
                Console.WriteLine("4. '4'");
                Console.WriteLine("5. '5'");
                Console.WriteLine("6. '6'");
                Console.WriteLine("7. '7'");
                Console.WriteLine("8. '8'");
                Console.WriteLine("9. '9'");
                Console.WriteLine("10. '10'");
                Console.WriteLine("11. Jack");
                Console.WriteLine("12. Queen");
                Console.WriteLine("13. King");
                var valueNum = GetIntFromUserInput();
                
                deck.AddCard(suitNum, valueNum);
                Console.WriteLine("Card added successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        private static void ViewAllCards(Deck deck)
        {
            Console.WriteLine("List of cards: ");
            var cards = deck.GetAllCards();
            foreach (var card in cards)
                Console.WriteLine($"Suit: {card.Suit}      Value: {card.Value}");
        }
    }
}