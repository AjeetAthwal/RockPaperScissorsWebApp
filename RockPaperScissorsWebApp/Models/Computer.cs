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

        public override RPSChoice GetRPSChoice()
        {
            return randomRPSChoice.Get();
        }

        public override RPSChoice GetRPSChoice(RPSChoice rPSChoice)
        {
            throw new ArgumentException();
        }

        RandomRPSChoice randomRPSChoice;
    }
}