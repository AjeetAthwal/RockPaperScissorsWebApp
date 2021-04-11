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
        public ActionResult PlayerVsPlayer()
        {
            return View();
        }

        public ActionResult PlayerVsComputer()
        {
            var model = game;
            return View(model);
        }
    }
}