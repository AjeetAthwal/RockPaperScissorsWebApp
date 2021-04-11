using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class Scoreboard
    {
        public Scoreboard(User player1, User player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            gamesPlayed = 0;
        }

        public void update(RPSP1P2Result result)
        {
            if (result == RPSP1P2Result.P1WIN) player1.addWin();
            else if (result == RPSP1P2Result.P2WIN) player2.addWin();
            gamesPlayed++;
        }

        User player1;
        User player2;
        private int gamesPlayed;
        public int Player1Wins
        {
            get { return player1.Wins; }
        }
        public int Player2Wins
        {
            get { return player2.Wins; }
        }
        public int GamesPlayed
        {
            get { return gamesPlayed; }
        }
        public int Draws
        {
            get { return gamesPlayed - Player1Wins - Player2Wins; }
        }

        internal void reset()
        {
            player1.resetWins();
            player2.resetWins();
            gamesPlayed = 0;
        }
    }
}