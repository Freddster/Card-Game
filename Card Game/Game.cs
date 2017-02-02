using System;
using System.Collections.Generic;

namespace Card_Game
{
    public class Game
    {
        private Deck _deck = new Deck();
        List<Player> playerList = new List<Player>();

        public Game()
        {
            
        }

        public void AddPlayer(Player player)
        {
            playerList.Add(player);
        }

        public void Deal()
        {
            foreach (var player in playerList)
            {
                player.DrawCard(_deck.DealCard());
            }
        }


        public void AnnounceWinner()
        {
            List<Player> winners = new List<Player>();
            winners.Add(new Player("N/A"));

            foreach (var player in playerList)
            {
                if (player.GetTotalValue()>winners[0].GetTotalValue())
                {
                    winners.Clear();
                    winners.Add(player);
                }
                else if (player.GetTotalValue() == winners[0].GetTotalValue())
                {
                    winners.Add(player);
                }
            
            }

            foreach (var player in winners)
            {
                Console.WriteLine($"The winner is {player.Name}");
            }
        }
    }
}