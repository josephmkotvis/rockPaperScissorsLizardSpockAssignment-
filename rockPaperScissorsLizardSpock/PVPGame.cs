using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissorsLizardSpock
{
    class PVPGame : Game
    {
        Player2name= Player.player2.name;
        public void RunPVPGame()
        {
            // create loop to run rounds until best of 3.
                // could do while loops for both winning conditions
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
        

    }
}
