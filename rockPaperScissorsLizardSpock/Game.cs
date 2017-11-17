using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class Game
    {
        string player1Name = Player.player1.name;
        string player2Name;
        string player2Status;
        string p1Choice;
        string p2Choice;
        string RoundWinner;
        double player1Score =0;
        double player2Score =0;
        public bool winningCondition = false;
        string hiddenKey= Console.ReadKey();
        public void ChooseGame(PVEGame pveGame, PVPGame pvpGame)
        {
            Console.WriteLine("Pick one of the following to play against:" + Environment.NewLine + "1)Computer" + Environment.NewLine + "2) Another Player");
            string gameChosen = Console.ReadLine();
            if (gameChosen.Equals("1"))
            {
                player2Status = "Computer";
            }
            else if (gameChosen.Equals("2"))
            {
                player2Status = "Player2";
            }
            else
            {
                Console.WriteLine("Please choose the number associated with the game choice.");
                ChooseGame(pveGame, pvpGame);
            }

        }
        public void RunGame()
        {
            while (!winningCondition)
            {
                ChoosePlayer1Choice();
                ChoosePlayer2Choice();
                CheckChoices();
                SetPlayerScores();
            }

        }
        public void ChoosePlayer1Choice()
        {
            Console.WriteLine("Choose one of the following:);
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void ChoosePlayer2Choice()
        {

            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void WinningRoundCondition()
        {
            // if player1choice>player2 Choice

        }
        public void WinningGameCondition()
        {
            if (player1Score == 2)
            {
                Console.WriteLine("Congratulations!" + player1Name + "has become victorious! GG!");
            }
            else if (player2Score == 2)
            {
                Console.WriteLine("Congratulations!" +player2Name + "has become victorious! GG!");
            }
            // check to see if score hit 2 (out of the 3 rounds)
                                    // or 3 (out of the 5 rounds)
        }
        //public void CheckChoicePVE()
       // {

        //}
        public void CheckChoices()
        {

        }
        public void AddPlayer1Score()
        {
            player1Score++; 
        }
        public void AddPLayer2Score()
        {
            player2Score++;
        }
        public void SetPlayerScores()
        {
            //Send who was winner to the function to update the score
        }
    }
}
