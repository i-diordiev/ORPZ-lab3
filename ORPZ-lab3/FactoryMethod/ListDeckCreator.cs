using ORPZ_lab3.Decks;

namespace ORPZ_lab3.FactoryMethod
{
    public class ListDeckCreator : DeckCreator
    {
        public override Deck CreateDeck()
        {
            return new ListDeck();
        }
    }
}