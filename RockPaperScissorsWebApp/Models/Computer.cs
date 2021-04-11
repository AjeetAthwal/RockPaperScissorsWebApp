using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class Computer : User
    {
        public Computer(RandomRPSChoice randomRPSChoice) : base()
        {
            this.randomRPSChoice = randomRPSChoice;
        }

        public override RPSChoice getRPSChoice()
        {
            return randomRPSChoice.Get();
        }

        RandomRPSChoice randomRPSChoice;
    }
}