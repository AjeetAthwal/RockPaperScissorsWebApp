using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class Player : User
    {
        public override RPSChoice GetRPSChoice(RPSChoice rPSChoice)
        {
            return rPSChoice;
        }

        public override RPSChoice GetRPSChoice()
        {
            throw new NotImplementedException();
        }
    }
}