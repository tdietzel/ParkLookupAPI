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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<State>()
      .HasData(
        new State { StateId = 1, Name = "Alabama" },
        new State { StateId = 2, Name = "Alaska" },
        new State { StateId = 3, Name = "Arizona" },
        new State { StateId = 4, Name = "Arkansas" },
        new State { StateId = 5, Name = "California" },
        new State { StateId = 6, Name = "Colorado" },
        new State { StateId = 7, Name = "Connecticut" },
        new State { StateId = 8, Name = "Delaware" },
        new State { StateId = 9, Name = "Florida" },
        new State { StateId = 10, Name = "Georgia" },
        new State { StateId = 11, Name = "Hawaii" },
        new State { StateId = 12, Name = "Idaho" },
        new State { StateId = 13, Name = "Illinois" },
        new State { StateId = 14, Name = "Indiana" },
        new State { StateId = 15, Name = "Iowa" },
        new State { StateId = 16, Name = "Kansas" },
        new State { StateId = 17, Name = "Kentucky" },
        new State { StateId = 18, Name = "Louisiana" },
        new State { StateId = 19, Name = "Maine" },
        new State { StateId = 20, Name = "Maryland" },
        new State { StateId = 21, Name = "Massachusetts" },
        new State { StateId = 22, Name = "Michigan" },
        new State { StateId = 23, Name = "Minnesota" },
        new State { StateId = 24, Name = "Mississippi" },
        new State { StateId = 25, Name = "Missouri" },
        new State { StateId = 26, Name = "Montana" },
        new State { StateId = 27, Name = "Nebraska" },
        new State { StateId = 28, Name = "Nevada" },
        new State { StateId = 29, Name = "New Hampshire" },
        new State { StateId = 30, Name = "New Jersey" },
        new State { StateId = 31, Name = "New Mexico" },
        new State { StateId = 32, Name = "New York" },
        new State { StateId = 33, Name = "North Carolina" },
        new State { StateId = 34, Name = "North Dakota" },
        new State { StateId = 35, Name = "Ohio" },
        new State { StateId = 36, Name = "Oklahoma" },
        new State { StateId = 37, Name = "Oregon" },
        new State { StateId = 38, Name = "Pennsylvania" },
        new State { StateId = 39, Name = "Rhode Island" },
        new State { StateId = 40, Name = "South Carolina" },
        new State { StateId = 41, Name = "South Dakota" },
        new State { StateId = 42, Name = "Tennessee" },
        new State { StateId = 43, Name = "Texas" },
        new State { StateId = 44, Name = "Utah" },
        new State { StateId = 45, Name = "Vermont" },
        new State { StateId = 46, Name = "Virginia" },
        new State { StateId = 47, Name = "Washington" },
        new State { StateId = 48, Name = "West Virginia" },
        new State { StateId = 49, Name = "Wisconsin" },
        new State { StateId = 50, Name = "Wyoming" }
      );

      builder.Entity<National>()
      .HasData(
        new National { NationalId = 1, Name = "National Parks Conservation Association"}
      );
    }
  }
}