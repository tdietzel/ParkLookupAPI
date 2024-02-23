using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkLookup.Models
{
  public class ParkLookupContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<State> States { get; set; }
    public DbSet<StatePark> StateParks { get; set; }
    public DbSet<National> National { get; set; }
    public DbSet<NationalPark> NationalParks { get; set; }
    public ParkLookupContext(DbContextOptions options) : base(options) { }
  }
}