using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NASCARTeams.Models;
using NASCARTeams.Data;

namespace NASCARTeams.Controllers
{
    public class HomeController : Controller
    {
        private readonly NASCARTeamsContext _context;
        private readonly ILogger<HomeController> _logger;
        public HomeController(NASCARTeamsContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogWarning("Testing");
            return View(_context.Team.ToList<Team>());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
