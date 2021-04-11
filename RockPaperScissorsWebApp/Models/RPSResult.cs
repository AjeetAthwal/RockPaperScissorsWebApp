using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public enum RPSResult
    {
        WIN,
        DRAW,
        LOSS
    }
    public static class RPSResultExtension
    {
        public static RPSResult Beats(RPSChoice choice1, RPSChoice choice2)
        {
            if (choice1 == choice2) return RPSResult.DRAW;
            if (((int)choice1 + 1) % Enum.GetValues(typeof(RPSChoice)).Length == (int)choice2)
            {
                return RPSResult.LOSS;
            }
            return RPSResult.WIN;
        }
    }
}