using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public abstract class User
    {
        public User()
        {
            wins = 0;
        }
        public void AddWin()
        {
            wins++;
        }

        public abstract RPSChoice GetRPSChoice(RPSChoice rPSChoice);
        private int wins;

        public int Wins { get => wins; }

        internal void ResetWins()
        {
            wins = 0;
        }
    }
}