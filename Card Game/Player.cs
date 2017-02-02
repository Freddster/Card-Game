using System;
using System.Collections.Generic;

namespace Card_Game
{
    public class Player
    {
        string _name = null;
        protected List<Card> cardsOnHand = new List<Card>();
        

        public Player(string name)
        {
            _name = name;
        }

        public virtual void DrawCard(Card card)
        {
            cardsOnHand.Add(card);
        }

        public int GetTotalValue()
        {
            int totalValue = 0;
            foreach (var card in cardsOnHand)
                totalValue += card.GetValue();
            return totalValue;
        }

        public void ShowHand()
        {
            Console.WriteLine($"Player {_name} is showing hand:");
            foreach (var card in cardsOnHand)
            {
                Console.WriteLine($"Suit: {card.Suit,10} Number: {card.Number}");
            }
        }

        public string Name
        {
            get { return _name; }
        }

    }
}