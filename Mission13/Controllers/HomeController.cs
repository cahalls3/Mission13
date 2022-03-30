using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission13.Models;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private IBowlingLeagueRepository _repo { get; set; }

        public HomeController(IBowlingLeagueRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var money = _repo.Bowlers
                .ToList();

            return View(money);
        }

        public IActionResult BowlerList()
        {
            var bowlers = _repo.Bowlers
                .OrderBy(x => x.BowlerID)
                .ToList();

            return View(bowlers);
        }

        public IActionResult Edit(int bowlerid)
        {
            ViewBag.Categories = _repo.Categories.ToList();

            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View("NewBowler", bowler);
        }

        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            _repo.Update(b);
            _repo.SaveChanges();

            return RedirectToAction("BowlerList");
        }

        [HttpGet]
        public IActionResult Delete(int bowlerid)
        {
            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View(bowler);
        }

        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            _repo.Bowlers.Remove(b);
            _repo.SaveChanges();

            return RedirectToAction("BowlerList");
        }

    }
}
