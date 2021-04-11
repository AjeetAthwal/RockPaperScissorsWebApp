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

        public GameController(ComputerGameData computerGame, PlayerGameData playerGame)
        {
            this.computerGame = computerGame.game;
            this.playerGame = playerGame.game;
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
            if (form["submit"] == "Play Round") computerGame.playRound((RPSChoice)0, (RPSChoice)0);
            else if (form["submit"] == "Reset Scores") computerGame.resetScores();

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
            if (form["submit"] == "Rock") playerGame.playRound(RPSChoice.ROCK, (RPSChoice)0);
            else if (form["submit"] == "Scissors") playerGame.playRound(RPSChoice.SCISSORS, (RPSChoice)0);
            else if (form["submit"] == "Paper") playerGame.playRound(RPSChoice.PAPER, (RPSChoice)0);
            else if (form["submit"] == "Reset Scores") playerGame.resetScores();

            var model = playerGame;
            return RedirectToAction("PlayerVsComputer", model);
        }
    }
}