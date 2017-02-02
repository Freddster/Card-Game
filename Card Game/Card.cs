using System;
using System.ComponentModel;

namespace Card_Game
{
    public class Card
    {
        private readonly int _suit;
        private readonly int _number;

        public enum CardSuits
        {
            Red = 1,
            Blue = 2,
            Green = 3,
            Yellow = 4,
            Gold = 5
        }

        public Card(int suit, int number)
        {
            _suit = suit;
            _number = number;
            
            /*Random rand = new Random();
            suit = rand.Next(1, 4);
            number = rand.Next(1, 8);*/
        }

        public int Suit
        {
            get { return _suit; }
        }
        
        public int Number
        {
            get { return _number; }
        }

        public int GetValue()
        {
            return _suit * _number;
        }
    }
}