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

    }
}
