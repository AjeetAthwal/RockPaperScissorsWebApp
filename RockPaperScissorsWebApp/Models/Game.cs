using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public enum RPSP1P2Result
    {
        P1WIN,
        DRAW,
        P2WIN
    }

    public class Game
    {
        public Game()
        {
            randomRPSChoice = new RandomRPSChoice();
            player1 = new Computer(randomRPSChoice);
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        public void playRound()
        {
            player1Choice = player1.getRPSChoice();
            player2Choice = player2.getRPSChoice();

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
    }
}