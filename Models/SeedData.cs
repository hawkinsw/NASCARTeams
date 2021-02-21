using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NASCARTeams.Data;
using System;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace NASCARTeams.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new NASCARTeamsContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<NASCARTeamsContext>>()))
      {
        // Look for any teams already in the database. If there
        // are any, then don't do any initialization.
        if (context.Team.Any())
        {
          var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
          logger.LogWarning("Database already seeded; doing nothing.");
          return;   // DB has been seeded
        }

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