using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RockPaperScissorsWebApp.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult PlayerVsPlayer()
        {
            return View();
        }

        public ActionResult PlayerVsComputer()
        {
            return View();
        }
    }
}