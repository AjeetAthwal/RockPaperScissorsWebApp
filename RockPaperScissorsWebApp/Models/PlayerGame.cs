using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class PlayerGame : Game
    {
        public PlayerGame()
        {
            randomRPSChoice = new RandomRPSChoice();
            player1 = new Player();
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        public override void PlayRound(RPSChoice rPSChoice)
        {
            player1Choice = player1.GetRPSChoice(rPSChoice);
            player2Choice = player2.GetRPSChoice();

            result = (RPSP1P2Result)RPSResultExtension.Beats(player1Choice, player2Choice);
            scoreboard.Update(result);
        }

        public override void PlayRound()
        {
            throw new ArgumentException();
        }

        public override void PlayRound(RPSChoice rPSChoice1, RPSChoice rPSChoice2)
        {
            throw new ArgumentException();
        }
    }
}