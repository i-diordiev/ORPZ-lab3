using System.Collections.Generic;
using ORPZ_lab3.Cards;

namespace ORPZ_lab3.Decks
{
    public abstract class Deck
    {
        public abstract void AddCard(int suit, int value);
        public abstract IEnumerable<PlayingCard> GetAllCards();
    }
}