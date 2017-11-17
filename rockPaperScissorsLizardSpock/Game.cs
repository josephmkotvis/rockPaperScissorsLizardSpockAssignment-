using System;

namespace rockPaperScissorsLizardSpock
{
    class Game
    {
        string player1Name;
        string player2Name;
        string player2Status;
        string player1Choice;
        double player1ChoiceNumber;
        string player2Choice;
        double player2ChoiceNumber;
        string RoundWinner;
        double player1Score =0;
        double player2Score =0;
        public bool winningCondition = false;
        public void ChooseGame()
        {
            Console.WriteLine("Pick one of the following to play against:" + Environment.NewLine + "1)Computer" + Environment.NewLine + "2) Another Player");
            string gameChosen = Console.ReadLine();
            if (gameChosen.Equals("1"))
            {
                player2Status = "Computer";
                RunGame();
            }
            else if (gameChosen.Equals("2"))
            {
                player2Status = "Player2";
                RunGame();
            }
            else
            {
                Console.WriteLine("Please choose the number associated with the game choice.");
                ChooseGame();
            }

        }
        public void RunGame()
        {
            do
            {
                ChoosePlayer1Choice();
                ChoosePlayer2Choice();
                CheckChoices();
                SetPlayerScores();
            } while (winningCondition == false);

        }
        public void ChoosePlayer1Choice()
        {
            Console.WriteLine("Player 1:" + Environment.NewLine + "Choose one of the following:" + Environment.NewLine + "1) Rock" + Environment.NewLine + "2) Paper" + Environment.NewLine + "3) Scissors" + Environment.NewLine + "4) Lizard" + Environment.NewLine + "5) Spock");
            char player1Input = Console.ReadKey(true).KeyChar;
            if (player1Input.Equals('1'))
            {
                player1Choice = "Rock";
            }
            else if (player1Input.Equals('2'))
            {
                player1Choice = "Paper";
            }
            else if (player1Input.Equals('3'))
            {
                player1Choice = "Scissors";
            }
            else if (player1Input.Equals('4'))
            {
                player1Choice = "Lizard";
            }
            else if (player1Input.Equals('5'))
            {
                player1Choice = "Spock";
            }
            else
            {
                Console.WriteLine("Please enter a correct number matching to your choise (1-5)");
                ChoosePlayer1Choice();
            }
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void ChoosePlayer2ComputerChoice()
        {
            Random luck = new Random();
            int randomComputerChoice = luck.Next(0, 6);
            switch (randomComputerChoice)
            {
                case 1:
                    player2Choice = "Rock";
                    player2ChoiceNumber = 1;
                    break;
                case 2:
                    player2Choice = "Paper";
                    player2ChoiceNumber = 2;
                    break;
                case 3:
                    player2Choice = "Scissors";
                    player2ChoiceNumber = 3;
                    break;
                case 4:
                    player2Choice = "Lizard";
                    player2ChoiceNumber = 4;
                    break;
                case 5:
                    player2Choice = "Spock";
                    player2ChoiceNumber = 5;
                    break;
            }
        }
        public void ChoosePlayer2HumanChoice()
        {
            Console.WriteLine("Player 2:" + Environment.NewLine + "Choose one of the following:" + Environment.NewLine + "1) Rock" + Environment.NewLine + "2) Paper" + Environment.NewLine + "3) Scissors" + Environment.NewLine + "4) Lizard" + Environment.NewLine + "5) Spock");
            char player2Input = Console.ReadKey(true).KeyChar;
            if (player2Input.Equals('1'))
            {
                player2Choice = "Rock";
                player2ChoiceNumber = 1;
            }
            else if (player2Input.Equals('2'))
            {
                player2Choice = "Paper";
                player2ChoiceNumber = 2;
            }
            else if (player2Input.Equals('3'))
            {
                player2Choice = "Scissors";
                player2ChoiceNumber = 3;
            }
            else if (player2Input.Equals('4'))
            {
                player2Choice = "Lizard";
                player2ChoiceNumber = 4;
            }
            else if (player2Input.Equals('5'))
            {
                player2Choice = "Spock";
                player2ChoiceNumber = 5;
            }
            else
            {
                Console.WriteLine("Please enter a correct number matching to your choise (1-5)");
                ChoosePlayer2Choice();
            }
            // Let user know its time to choose
            //direct to the choose/calcualte function in the player class
        }
        public void ChoosePlayer2Choice()
        {
            if (player2Status == "Player2")
            {
                ChoosePlayer2HumanChoice();
            }
            else if (player2Status == "Computer")
            {
                ChoosePlayer2ComputerChoice();
            }
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
