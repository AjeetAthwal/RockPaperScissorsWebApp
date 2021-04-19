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
        private readonly Game playerGame;

        public GameController(GameData gameData)
        {
            this.computerGame = gameData.computerGame;
            this.playerGame = gameData.playerGame;
        }

        // GET: Game
        [HttpGet]
        public ActionResult ComputerVsComputer()
        {
            var model = computerGame;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComputerVsComputer(FormCollection form)
        {
            if (form["submit"] == "Play Round") computerGame.PlayRound();
            else if (form["submit"] == "Reset Scores") computerGame.ResetScores();

            var model = computerGame;
            return RedirectToAction("ComputerVsComputer", model);
        }

        [HttpGet]
        public ActionResult PlayerVsComputer()
        {
            var model = playerGame;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PlayerVsComputer(FormCollection form)
        {
            if (form["submit"] == "Rock") playerGame.PlayRound(RPSChoice.ROCK);
            else if (form["submit"] == "Scissors") playerGame.PlayRound(RPSChoice.SCISSORS);
            else if (form["submit"] == "Paper") playerGame.PlayRound(RPSChoice.PAPER);
            else if (form["submit"] == "Reset Scores") playerGame.ResetScores();

            var model = playerGame;
            return RedirectToAction("PlayerVsComputer", model);
        }
    }
}