using System;
using System.ComponentModel.DataAnnotations;

namespace NASCARTeams.Models
{
  public class Team
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Owner { get; set; }
    public string Driver { get; set; }
    public string Number { get; set; }
    [Display(Name = "Crew Chief")]
    public string CrewChief { get; set; }
  }
}