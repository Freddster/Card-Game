using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Player Roseneagle = new WeakPlayer("Roseneagle");
            Player Hansen = new Player("Iceman");
            Player Andersen = new Player("Andersen");
            

            game.AddPlayer(Roseneagle);
            game.AddPlayer(Hansen);
            game.AddPlayer(Andersen);

            game.Deal();
            game.Deal();
            game.Deal();

            Roseneagle.ShowHand();

            game.Deal();

            Roseneagle.ShowHand();

            Console.WriteLine($"Roseneagle: {Roseneagle.GetTotalValue()}");
            Console.WriteLine($"Andersen: {Andersen.GetTotalValue()}");
            Console.WriteLine($"Hansen: {Hansen.GetTotalValue()}");

            game.AnnounceWinner();

            Console.ReadKey();
        }
    }
}
