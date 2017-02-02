using System;
using System.Collections.Generic;
using System.Linq;

namespace Card_Game
{
    public class Deck
    {
        List<Card> _deck = new List<Card>();

        public Deck()
        {
            for (var suitToGive = 1; suitToGive < new Card(0,0).Biggestmultiplier(); suitToGive++)
            {
                for (var numberToGive = 1; numberToGive< 9; numberToGive++)
                {
                    var cardToAdd = new Card(suitToGive, numberToGive);
                    _deck.Add(cardToAdd);
                }
            }
        }
    
        public Card DealCard()
        {
            var rand = new Random();
            var num = rand.Next(1, _deck.Count);
            var cardToReturn = _deck[num];
            _deck.RemoveAt(num);
            return cardToReturn;
        }
    }
}