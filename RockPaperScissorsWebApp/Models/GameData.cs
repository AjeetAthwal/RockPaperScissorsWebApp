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
            computerGame = new Game(GameState.COMPUTERVSCOMPUTER);
            playerGame = new Game(GameState.PLAYERVSCOMPUTER);
        }
        public Game computerGame;
        public Game playerGame;
    }
}