using Microsoft.EntityFrameworkCore;
using NASCARTeams.Models;

namespace NASCARTeams.Data
{
  public class NASCARTeamsContext : DbContext
  {
    public NASCARTeamsContext(DbContextOptions<NASCARTeamsContext> options)
        : base(options)
    {
    }

    public DbSet<Team> Team { get; set; }
  }
}