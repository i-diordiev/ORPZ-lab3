using ORPZ_lab3.Cards;

namespace ORPZ_lab3.FactoryMethod
{
    public static class CardCreator
    {
        public static PlayingCard CreateCard(int suit, int value)
        {
            Suit s = (Suit)suit;
            Value v = (Value)value;

            return new PlayingCard() { Suit = s, Value = v };
        }
    }
}