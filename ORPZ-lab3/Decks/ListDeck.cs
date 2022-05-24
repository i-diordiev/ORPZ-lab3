using System;
using System.Collections.Generic;
using System.Linq;
using ORPZ_lab3.Cards;
using ORPZ_lab3.FactoryMethod;

namespace ORPZ_lab3.Decks
{
    public class ListDeck : Deck
    {
        private LinkedList<PlayingCard> _cards;

        public ListDeck()
        {
            _cards = new LinkedList<PlayingCard>();
        }

        public override void AddCard(int suit, int value)
        {
            if (_cards.Count >= 52)
                throw new Exception("Card limit exceeded.");

            var card = CardCreator.CreateCard(suit, value);
            
            if (_cards.FirstOrDefault(c => c.Suit == card.Suit && c.Value == card.Value) != null)
                throw new Exception("This card already exists in this deck.");
            
            _cards.AddLast(card);
        }

        public override IEnumerable<PlayingCard> GetAllCards()
        {
            return _cards.ToList();
        }
    }
}