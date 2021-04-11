using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class Player : User
    {
        public override RPSChoice getRPSChoice(RPSChoice rPSChoice)
        {
            return rPSChoice;
        }
    }
}