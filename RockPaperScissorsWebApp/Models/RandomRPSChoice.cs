using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class RandomRPSChoice
    {
        public RandomRPSChoice()
        {
            r = new Random();
        }

        internal RandomRPSChoice(int seed)
        {
            r = new Random(seed);
        }

        public RPSChoice Get()
        {
            return (RPSChoice)r.Next(0, Enum.GetValues(typeof(RPSChoice)).Length);
        }

        internal readonly Random r;
    }
}