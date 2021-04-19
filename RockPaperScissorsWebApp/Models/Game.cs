using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public abstract class Game
    {
        public abstract void PlayRound();
        public abstract void PlayRound(RPSChoice rPSChoice);
        public abstract void PlayRound(RPSChoice rPSChoice1, RPSChoice rPSChoice2);

        protected RandomRPSChoice randomRPSChoice;
        protected User player1;
        protected User player2;
        protected Scoreboard scoreboard;
        protected RPSChoice player1Choice;
        protected RPSChoice player2Choice;
        protected RPSP1P2Result result;
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