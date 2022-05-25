using System;
using System.Collections.Generic;
using System.Linq;
using ORPZ_lab3.Cards;
using ORPZ_lab3.FactoryMethod;

namespace ORPZ_lab3.Decks
{
    public class ArrayDeck : Deck
    {
        private PlayingCard[] _cards;

        public ArrayDeck()
        {
            _cards = new PlayingCard[52];
        }
        
        public override void AddCard(int suit, int value)
        {
            if (_cards[51] != null)
                throw new Exception("Card limit exceeded.");

            var card = CardCreator.CreateCard(suit, value);
            var cards = GetAllCards();
            if (cards.FirstOrDefault(c => c.Suit == card.Suit && c.Value == card.Value) != null)
                throw new Exception("This card already exists in this deck.");
            
            for (int i = 0; i < _cards.Length; i++)
            {
                if (_cards[i] == null)
                {
                    _cards[i] = card;
                    break;
                }
            }
        }

        public override IEnumerable<PlayingCard> GetAllCards()
        {
            return _cards.Where(c => c != null).ToList();
        }
    }
}