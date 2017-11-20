using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player1 = new Player("Player1", "Not Chosen", 0, 0, 1);
            Player2 Player2 = new Player2("Player2", "Not Chosen", 0, 0, 2, "Not Confirmed");
            Game Round = new Game();
            Round.RunGame(Player1, Player2);
            Console.ReadKey();
        }
    }
}
