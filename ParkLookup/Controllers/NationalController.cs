using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ParkLookup.Models;

namespace ParkLookup.Controllers;

[ApiController]
[Route("[controller]")]
public class NationalController : ControllerBase
{
  private readonly ParkLookupContext _db;
  public NationalController(ParkLookupContext db)
  {
    _db = db;
  }

  [HttpGet("Park")]
  public async Task<ActionResult<List<National>>> Get()
  {
    return await _db.National.Include(s => s.Parks).ToListAsync();
  }

  [HttpPost("Park")]
  public async Task<ActionResult<NationalPark>> Post(NationalPark park)
  {
    _db.NationalParks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(Get), new { id = park.NationalParkId }, park);
  }
}