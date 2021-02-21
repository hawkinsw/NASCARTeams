using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NASCARTeams.Data;
using System;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace NASCARTeams.Models
{
  // This is a class that will seed the database with some information,
  // if the database is currently empty. It is a static class, meaning
  // that its Initialize method can be called without instantiating SeedData. The
  // web application invokes the Initialize method directly at startup.
  public static class SeedData
  {
    // This method is invoked directly in Program.cs from the Main function.
    // That is the function that starts everything in the web application. It
    // is the responsibility of this class to determine whether to put data
    // in the database or not. In other words, this function is called every
    // time that the program is started regardless of the state of the database.
    public static void Initialize(IServiceProvider serviceProvider)
    {
      // The using statement is important here because the database context
      // manages resources that are outside the runtime. As soon as the scope
      // of the using ends, the Dispose method of the DB context is called. using
      // also makes sure that the Dispose method is called even if an exception
      // occurs during execution of the code block.
      using (var context = new NASCARTeamsContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<NASCARTeamsContext>>()))
      {
        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
        // Look for any teams already in the database. If there
        // are any, then don't do any initialization.
        if (context.Team.Any())
        {
          logger.LogWarning("Database already seeded; adding no data.");
          return;   // DB has been seeded
        }

        logger.LogInformation("Seeding the empty NASCAR Teams database with two teams.");
        context.Team.AddRange(
            new Team
            {
              Name = "#4 Stewart-Haas Racing Team",
              Owner = "Stewart-Haas Racing",
              Driver = "Kevin Harvick",
              CrewChief = "Rodney Childers",
              Number = "4",
            },
            new Team
            {
              Name = "#18 Joe Gibbs Racing Toyota",
              Owner = "Joe Gibbs Racing",
              Driver = "Kyle Busch",
              CrewChief = "Ben Beshore",
              Number = "18",
            }
        );
        context.SaveChanges();
      }
    }
  }
}