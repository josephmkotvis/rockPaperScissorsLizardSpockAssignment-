using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class Player2 : Player
    {
        public string status;
        public Player2(string name, string choice, double choiceNumber, double score, string status)
            : base(name, choice, choiceNumber, score)
        {
            this.status = status;
        }
        public void CheckPlayer2Status()
        {
            if (status == "Player2")
            {
                ChoosePlayerChoice();
            }
            else if (status == "Computer")
            {
                ChooseComputerChoice();
            }
        }
        public void ChooseOpponent()

        {
            Console.WriteLine("Pick one of the following to play against:" + Environment.NewLine + "1) Computer" + Environment.NewLine + "2) Another Player");
            string gameChosen = Console.ReadLine();
            if (gameChosen.Equals("1"))
            {
                SetOpponentToComputer();
            }
            else if (gameChosen.Equals("2"))
            {
                SetOpponentToPlayer();
            }
            else
            {
                Console.WriteLine("Please choose the number associated with the game choice.");
            }

        }
        public void SetOpponentToComputer()
        {
            status = "Computer";
            name = "Computer";
        }
        public void SetOpponentToPlayer()
        {
            WritePlayerName();
            status = "Player2";
        }
        public void ChooseComputerChoice()
        {
            Random luck = new Random();
            int randomComputerChoice = luck.Next(1, 5);
            switch (randomComputerChoice)
            {
                case 1:
                    choice = "Rock";
                    choiceNumber = 0;
                    break;
                case 2:
                    choice = "Paper";
                    choiceNumber = 1;
                    break;
                case 3:
                    choice = "Scissors";
                    choiceNumber = 2;
                    break;
                case 4:
                    choice = "Spock";
                    choiceNumber = 3;
                    break;
                case 5:
                    choice = "Lizard";
                    choiceNumber = 4;
                    break;
            }
        }
    }
}
