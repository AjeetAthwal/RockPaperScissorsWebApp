using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsWebApp.Models
{
    public class ComputerGameData
    {
        public ComputerGameData()
        {
            game = new Game(GameState.COMPUTERVSCOMPUTER);
        }
        public Game game;
    }

    public class PlayerGameData
    {
        public PlayerGameData()
        {
            game = new Game(GameState.PLAYERVSCOMPUTER);
        }
        public Game game;
    }
}