using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class Game
    {
        public Game(GameState gameState)
        {
            randomRPSChoice = new RandomRPSChoice();
            if (gameState == GameState.COMPUTERVSCOMPUTER) player1 = new Computer(randomRPSChoice);
            else player1 = new Player();
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        public void playRound(RPSChoice rPSChoice1, RPSChoice rPSChoice2)
        {
            player1Choice = player1.getRPSChoice(rPSChoice1);
            player2Choice = player2.getRPSChoice(rPSChoice2);

            result = (RPSP1P2Result)RPSResultExtension.Beats(player1Choice, player2Choice);
            scoreboard.update(result);
        }

        RandomRPSChoice randomRPSChoice;
        private readonly User player1;
        private readonly User player2;
        private Scoreboard scoreboard;
        private RPSChoice player1Choice;
        private RPSChoice player2Choice;
        private RPSP1P2Result result;
        public int player1wins
        {
            get { return scoreboard.Player1Wins; }
        }

        internal void resetScores()
        {
            scoreboard.reset();
        }

        public int player2wins
        {
            get { return scoreboard.Player2Wins; }
        }
        public int gamesPlayed
        {
            get { return scoreboard.GamesPlayed; }
        }
        public int draws
        {
            get { return scoreboard.Draws; }
        }

        public RPSChoice Player1Choice { get => player1Choice; }
        public RPSChoice Player2Choice { get => player2Choice; }
        public RPSP1P2Result Result { get => result; }
    }
}