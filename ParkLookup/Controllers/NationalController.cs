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

  [Authorize]
  [HttpPost("Park")]
  public async Task<ActionResult<NationalPark>> Post(NationalPark park)
  {
    _db.NationalParks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(Get), new { id = park.NationalParkId }, park);
  }

  private bool ParkExists(int id)
  {
    return _db.NationalParks.Any(park => park.NationalParkId == id);
  }
  [Authorize]
  [HttpPut("Park/{id}")]
  public async Task<IActionResult> Put(int id, NationalPark park)
  {
    if (id != park.NationalParkId)
    {
      return BadRequest();
    }

    _db.NationalParks.Update(park);

    try 
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!ParkExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }

    return NoContent();
  }

  [Authorize]
  [HttpDelete("Park/{id}")]
  public async Task<IActionResult> DeletePark(int id)
  {
    NationalPark park = await _db.NationalParks.FindAsync(id);
    if (park == null)
    {
      return NotFound();
    }
    _db.NationalParks.Remove(park);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}