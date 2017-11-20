using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class Player
    {
        public string name;
        public string choice;
        public double choiceNumber;
        public double score = 0;
        public double playerNumber;
        public Player(string name, string choice, double choiceNumber, double score, double playerNumber)
        {
            this.name = name;
            this.choice = choice;
            this.choiceNumber = choiceNumber;
            this.score = score;
            this.playerNumber = playerNumber;
        }
        public void WritePlayerName()
        {
            Console.WriteLine(Environment.NewLine + "" + name + ", write your name.");
            name = Console.ReadLine();
        }
        public void ChoosePlayerChoice()
        {
            Console.WriteLine(Environment.NewLine + "" + name + ":" + Environment.NewLine + "Choose one of the following:" + Environment.NewLine + "1) Rock" + Environment.NewLine + "2) Paper" + Environment.NewLine + "3) Scissors" + Environment.NewLine + "4) Spock" + Environment.NewLine + "5) Lizard");
            char playerInput = Console.ReadKey(true).KeyChar;
            if (playerInput.Equals('1'))
            {
                SetChoiceToRock();
            }
            else if (playerInput.Equals('2'))
            {
                SetChoiceToPaper();
            }
            else if (playerInput.Equals('3'))
            {
                SetChoiceToScissors();
            }
            else if (playerInput.Equals('4'))
            {
                SetChoiceToSpock();
            }
            else if (playerInput.Equals('5'))
            {
                SetChoiceToLizard();
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Please enter a correct number matching to your choise (1-5)");
                ChoosePlayerChoice();
            }
        }
        public void SetChoiceToRock()
        {
            choice = "Rock";
            choiceNumber = 0;
        }
        public void SetChoiceToPaper()
        {
            choice = "Paper";
            choiceNumber = 1;
        }
        public void SetChoiceToScissors()
        {
            choice = "Scissors";
            choiceNumber = 2;
        }
        public void SetChoiceToSpock()
        {
            choice = "Spock";
            choiceNumber = 3;
        }
        public void SetChoiceToLizard()
        {
            choice = "Lizard";
            choiceNumber = 4;
        }
        public void AddScore()
        {
            score++;
        }
        public void ResetStats()
        {
            score = 0;
            name = "Player"+ playerNumber;
        }
    }
}