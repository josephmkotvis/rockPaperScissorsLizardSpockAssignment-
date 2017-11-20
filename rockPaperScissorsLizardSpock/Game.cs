using System;

namespace rockPaperScissorsLizardSpock
{
    class Game
    {
        string roundWinner;
        public bool winningCondition = false;

        public void RunGame(Player player1, Player2 player2)
        {
            player1.WritePlayerName();
            player2.ChooseOpponent();

            do
            {
                player1.ChoosePlayerChoice();
                player2.CheckPlayer2Status();
                CheckChoices(player1, player2);
                SetPlayerScores(player1, player2);
                WinningGameCondition(player1, player2);
            } while (winningCondition == false);
            AskToPlayAgain(player1, player2);
        }

        public void WinningGameCondition(Player player1, Player2 player2)
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Congratulations!" + player1.name + " has become victorious! GG!");
                winningCondition = true;
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Congratulations!" + player2.name + " has become victorious! GG!");
                winningCondition = true;
            }
        }
        public void CheckChoices(Player player1, Player2 player2)
        {
            double roundWinnerChecked = ((5 + player1.choiceNumber - player2.choiceNumber) % 5);
            if (roundWinnerChecked == 1)
            {
                roundWinner = "Player1";
            }
            else if (roundWinnerChecked == 3)
            {
                roundWinner = "Player1";
            }
            else if (roundWinnerChecked == 2)
            {
                roundWinner = "Player2";
            }
            else if (roundWinnerChecked == 4)
            {
                roundWinner = "Player2";
            }
            else
            {
                roundWinner = "Neither";
               
            }
        }
        public void SetPlayerScores(Player player1, Player2 player2)
        {
           if (roundWinner == "Player1")
            {
                Console.WriteLine(player1.name + " has won this round with " + player1.choice + " against " + player2.name + "'s " + player2.choice + ".");
                player1.AddScore();
            }
           else if (roundWinner == "Player2")
            { 
                Console.WriteLine(player2.name + " has won this round with " + player2.choice + " against " + player1.name + "'s " + player1.choice + ".");
                player2.AddScore();
            }
            else if ( roundWinner == "Neither")
            {
                Console.WriteLine("There was a tie with " + player1.name + "'s " + player1.choice + " against " + player2.name + "'s " + player2.choice + "! Try again.");
            }
        }
        public void AskToPlayAgain(Player player1, Player2 player2)
        {
            Console.WriteLine("Would you like to play again? (y/n)";
            string playerReplayResponse = Console.ReadLine();
            if (playerReplayResponse == "y")
            {
                RunGame(player1, player2);
            }
            else if (playerReplayResponse == "n")
            {
                Console.WriteLine("Hope you had fun!");
            }
            else
            {
                Console.WriteLine("Please write y or n for your appropriate answer");
                AskToPlayAgain(player1, player2);
            }
        }
    }
}
