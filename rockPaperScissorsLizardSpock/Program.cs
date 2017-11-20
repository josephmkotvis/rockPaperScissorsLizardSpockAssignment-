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
            Player Player1 = new Player();
            Player Player2 = new Player();
            Game Practice = new Game();
            Practice.ChooseGame();
            Console.ReadKey();

        }
    }
}
