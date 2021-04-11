using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RockPaperScissorsWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly Game computerGame;

        public GameController(ComputerGameData computerGame)
        {
            this.computerGame = computerGame.game;
        }

        // GET: Game
        [HttpGet]
        public ActionResult ComputerVsComputer()
        {
            var model = computerGame;
            return View(model);
        }

        [HttpGet]
        public ActionResult PlayerVsComputer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComputerVsComputer(Game game)
        {
            computerGame.playRound();
            var model = computerGame;
            return View(model);
        }
    }
}