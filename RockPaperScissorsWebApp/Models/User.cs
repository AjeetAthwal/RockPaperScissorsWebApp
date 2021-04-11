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
        public void addWin()
        {
            wins++;
        }

        public abstract RPSChoice getRPSChoice();
        private int wins;

        public int Wins { get => wins; }
    }
}