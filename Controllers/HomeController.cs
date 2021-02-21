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

    // This is awesome: This constructor can take as many parameters as there
    // are items injected into the environment. Adding them as parameters here
    // means that they are requested from the service environment at runtime
    // when the class is created -- Dependency Injection. Quite cool, I think!
    // So, we request access to the database context (to get a list of all the
    // the teams in the database in the Index method) and the logger so that we
    // can log any warnings or errors, if needed.
    public HomeController(NASCARTeamsContext context, ILogger<HomeController> logger)
    {
      _context = context;
      _logger = logger;
    }

    public IActionResult Index()
    {
      _logger.LogInformation("Calling Index in the HomeController.");
      return View(_context.Team.ToList<Team>());
    }

    public IActionResult Privacy()
    {
      _logger.LogInformation("Calling Privacy in the HomeController.");
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
