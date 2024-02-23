using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkLookup.Models
{
  public class ParkLookupDbContext : IdentityDbContext<ApplicationUser>
  {
    public ParkLookupDbContext(DbContextOptions options) : base(options) { }

  }

}