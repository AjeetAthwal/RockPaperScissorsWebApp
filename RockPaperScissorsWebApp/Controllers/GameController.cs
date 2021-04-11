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
        private readonly Game game;

        public GameController(Game game)
        {
            this.game = game;
        }

        // GET: Game
        [HttpGet]
        public ActionResult ComputerVsComputer()
        {
            var model = game;
            return View(model);
        }

        [HttpGet]
        public ActionResult PlayerVsComputer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ComputerVsComputer(Game game)
        {
            game.playRound();
            var model = game;
            return View(model);
        }
    }
}