using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class ComputerGame : Game
    {
        public ComputerGame()
        {
            randomRPSChoice = new RandomRPSChoice();
            player1 = new Computer(randomRPSChoice);
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        internal ComputerGame(int seed)
        {
            randomRPSChoice = new RandomRPSChoice(seed);
            player1 = new Computer(randomRPSChoice);
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        public override void PlayRound()
        {
            player1Choice = player1.GetRPSChoice();
            player2Choice = player2.GetRPSChoice();

            result = (RPSP1P2Result)RPSResultExtension.Beats(player1Choice, player2Choice);
            scoreboard.Update(result);
        }

        public override void PlayRound(RPSChoice rPSChoice)
        {
            throw new ArgumentException();
        }

        public override void PlayRound(RPSChoice rPSChoice1, RPSChoice rPSChoice2)
        {
            throw new ArgumentException();
        }
    }
}