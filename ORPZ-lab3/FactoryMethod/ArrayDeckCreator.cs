using ORPZ_lab3.Decks;

namespace ORPZ_lab3.FactoryMethod
{
    public class ArrayDeckCreator : DeckCreator
    {
        public override Deck CreateDeck()
        {
            return new ArrayDeck();
        }
    }
}