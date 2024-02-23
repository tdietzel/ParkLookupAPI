using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkLookup.Models
{
  public class ParkLookupContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<State> States { get; set; }
    public DbSet<StatePark> StateParks { get; set; }
    public ParkLookupContext(DbContextOptions options) : base(options) { }
  }
}