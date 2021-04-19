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

        internal Game(GameState gameState, int seed)
        {
            randomRPSChoice = new RandomRPSChoice(seed);
            if (gameState == GameState.COMPUTERVSCOMPUTER) player1 = new Computer(randomRPSChoice);
            else player1 = new Player();
            player2 = new Computer(randomRPSChoice);
            scoreboard = new Scoreboard(player1, player2);
        }

        public void playRound(RPSChoice rPSChoice1, RPSChoice rPSChoice2)
        {
            player1Choice = player1.GetRPSChoice(rPSChoice1);
            player2Choice = player2.GetRPSChoice(rPSChoice2);

            result = (RPSP1P2Result)RPSResultExtension.Beats(player1Choice, player2Choice);
            scoreboard.Update(result);
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

        internal void ResetScores()
        {
            scoreboard.Reset();
        }

        public int Player2wins
        {
            get { return scoreboard.Player2Wins; }
        }
        public int GamesPlayed
        {
            get { return scoreboard.GamesPlayed; }
        }
        public int Draws
        {
            get { return scoreboard.Draws; }
        }

        public RPSChoice Player1Choice { get => player1Choice; }
        public RPSChoice Player2Choice { get => player2Choice; }
        public RPSP1P2Result Result { get => result; }
    }
}