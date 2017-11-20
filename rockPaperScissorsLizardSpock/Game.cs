using System;

namespace rockPaperScissorsLizardSpock
{
    class Game
    {
        //string player1Name;
        //string player2Name;
        //string player2Status;
        //string player1Choice;
        //double player1ChoiceNumber;
        //string player2Choice;
        //double player2ChoiceNumber;
        string roundWinner;
        //double player1Score =0;
        //double player2Score =0;
        public bool winningCondition = false;
        public void ChooseGame(Player player1, Player2 player2)
        {
            Console.WriteLine("Pick one of the following to play against:" + Environment.NewLine + "1)Computer" + Environment.NewLine + "2) Another Player");
            string gameChosen = Console.ReadLine();
            if (gameChosen.Equals("1"))
            {
                player2.status = "Computer";
                player2.name = "Computer";
                RunGame(player1, player2);
            }
            else if (gameChosen.Equals("2"))
            {
                player2.status = "Player2";
                RunGame(player1, player2);
            }
            else
            {
                Console.WriteLine("Please choose the number associated with the game choice.");
                ChooseGame(player1, player2);
            }

        }
        public void RunGame(Player player1, Player2 player2)
        {
            do
            {
                ChoosePlayer1Choice(player1);
                ChoosePlayer2Choice(player2);
                CheckChoices(player1, player2);
                SetPlayerScores(player1, player2);
                WinningGameCondition(player1, player2);
            } while (winningCondition == false);

        }
        public void WritePlayer1Name(Player player1)
        {
            Console.WriteLine("Player 1, write your name.");
            player1.name = Console.ReadLine();
        }
        public void WritePlayer2Name (Player2 player2)
        {
            Console.WriteLine("Player 2, write your name.");
            player2.name = Console.ReadLine();
        }
        public void ChoosePlayer1Choice(Player player1)
        {
            Console.WriteLine( player1.name + ":" + Environment.NewLine + "Choose one of the following:" + Environment.NewLine + "1) Rock" + Environment.NewLine + "2) Paper" + Environment.NewLine + "3) Scissors" + Environment.NewLine + "4) Lizard" + Environment.NewLine + "5) Spock");
            char player1Input = Console.ReadKey(true).KeyChar;
            if (player1Input.Equals('1'))
            {
                player1.choiceNumber = 0;
                return ;
            }
            else if (player1Input.Equals('2'))
            {
                player1.choice = "Paper";
                player1.choiceNumber = 1;
            }
            else if (player1Input.Equals('3'))
            {
                player1.choice = "Scissors";
                player1.choiceNumber = 2;
            }
            else if (player1Input.Equals('4'))
            {
                player1.choice = "Lizard";
                player1.choiceNumber = 3;
            }
            else if (player1Input.Equals('5'))
            {
                player1.choice = "Spock";
                player1.choiceNumber = 4;
            }
            else
            {
                Console.WriteLine("Please enter a correct number matching to your choise (1-5)");
                ChoosePlayer1Choice(player1);
            }
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void ChoosePlayer2ComputerChoice(Player player2)
        {
            Random luck = new Random();
            int randomComputerChoice = luck.Next(0, 6);
            switch (randomComputerChoice)
            {
                case 1:
                    player2.choice = "Rock";
                    player2.choiceNumber = 0;
                    break;
                case 2:
                    player2.choice = "Paper";
                    player2.choiceNumber = 1;
                    break;
                case 3:
                    player2.choice = "Scissors";
                    player2.choiceNumber = 2;
                    break;
                case 4:
                    player2.choice = "Lizard";
                    player2.choiceNumber = 3;
                    break;
                case 5:
                    player2.choice = "Spock";
                    player2.choiceNumber = 4;
                    break;
            }
        }
        public void ChoosePlayer2HumanChoice(Player2 player2)
        {
            Console.WriteLine(player2.name + ":" + Environment.NewLine + "Choose one of the following:" + Environment.NewLine + "1) Rock" + Environment.NewLine + "2) Paper" + Environment.NewLine + "3) Scissors" + Environment.NewLine + "4) Lizard" + Environment.NewLine + "5) Spock");
            char player2Input = Console.ReadKey(true).KeyChar;
            if (player2Input.Equals('1'))
            {
                player2.choice = "Rock";
                player2.choiceNumber = 0;
            }
            else if (player2Input.Equals('2'))
            {
                player2.choice = "Paper";
                player2.choiceNumber = 1;
            }
            else if (player2Input.Equals('3'))
            {
                player2.choice = "Scissors";
                player2.choiceNumber = 2;
            }
            else if (player2Input.Equals('4'))
            {
                player2.choice = "Lizard";
                player2.choiceNumber = 3;
            }
            else if (player2Input.Equals('5'))
            {
                player2.choice = "Spock";
                player2.choiceNumber = 4;
            }
            else
            {
                Console.WriteLine("Please enter a correct number matching to your choise (1-5)");
                ChoosePlayer2Choice(player2);
            }
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void ChoosePlayer2Choice(Player2 player2)
        {
            if (player2.status == "Player2")
            {
                ChoosePlayer2HumanChoice(player2);
            }
            else if (player2.status == "Computer")
            {
                ChoosePlayer2ComputerChoice(player2);
            }
        }
        public bool WinningGameCondition(Player player1, Player2 player2)
        {
            winningCondition = false;
            if (player1.score == 2)
            {
                Console.WriteLine("Congratulations!" + player1.name + "has become victorious! GG!");
                return true;
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Congratulations!" + player2.name + "has become victorious! GG!");
                return true;
            }
            else
            {
                return false;
            }
            // check to see if score hit 2 (out of the 3 rounds)
                                    // or 3 (out of the 5 rounds)
        }
        //public void CheckChoicePVE()
       // {

        //}
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
        public void AddPlayer1Score(Player player1)
        {
            player1.score++; 
        }
        public void AddPLayer2Score(Player2 player2)
        {
            player2.score++;
        }
        public void SetPlayerScores(Player player1, Player2 player2)
        {
           if (roundWinner == "Player1")
            {
                Console.WriteLine(player1.name + "has won this round!");
                AddPlayer1Score(player1);
            }
           else if (roundWinner == "Player2")
            { 
                Console.WriteLine(player2.name + "has won this round!");
                AddPLayer2Score(player2);
            }
            else if ( roundWinner == "Neither")
            {
                Console.WriteLine("You have tied! Try again.");
            }
            
            //Send who was winner to the function to update the score
        }
    }
}
