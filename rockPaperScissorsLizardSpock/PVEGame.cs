using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class PVEGame : Game
    {
        Player2name= Computer.name;
        public void NotifyPVEChoice()
        {
            Console.WriteLine("You have chosen to play the PVE version of this game");
            RunPVEGame();
        }
        public void RunPVEGame(Game game)
        {
            while (game.winningCondition == false)
            {
                DisplayChoosePrompt();
                SendChoices();
                CheckChoices();



            }
            // create loop to run round checking answers
            // could do while loops for both winning conditions
            // while winning condition! 
            //while choice 1 = choice2, run 

        }
        public void DisplayChoosePrompt()
        {
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class

        }
        public void DisplayWhoWonRound()
        {
            //Displays p1 lost that round

        }
        public void SetPlayerScores()
        {
            //Send who was winner to the function to update the score
        }
        public void SendChoices()
        {
            //send players choices to check who won
        }
        public void CalcualteComputerChoice()
        {
            // use random method to calculate what the computer would choose
        }
        public void MatchComputerChoice()
        {
            //match the output from CalculateComputerChoice to an output for Choice method
        }
    }
}
