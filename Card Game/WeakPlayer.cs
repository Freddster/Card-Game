namespace Card_Game
{
    public class WeakPlayer : Player
    {
        public WeakPlayer(string name) : base(name) { }

        public override void DrawCard(Card card)
        {
            base.DrawCard(card);
            //Holding 4 cards

            if (cardsOnHand.Count >= 4)
            {
                int value = 0;
                Card temp = new Card(4, 8);
                foreach (var cards in base.cardsOnHand)
                {
                    if (temp.GetValue() > cards.GetValue())
                    {
                        temp = cards;
                    }
                }
                cardsOnHand.Remove(temp);
            }
        }
    }
}