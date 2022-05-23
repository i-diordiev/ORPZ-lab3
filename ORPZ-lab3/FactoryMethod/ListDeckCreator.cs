using ORPZ_lab3.Decks;

namespace ORPZ_lab3.FactoryMethod
{
    public class ListDeckCreator : IDeckCreator
    {
        public Deck CreateDeck()
        {
            return new ListDeck();
        }
    }
}