using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class GameData
    {
        public GameData()
        {
            computerGame = new ComputerGame();
            playerGame = new PlayerGame();
        }
        public Game computerGame;
        public Game playerGame;
    }
}