using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ParkLookup.Models;

namespace ParkLookup.Controllers;

[ApiController]
[Route("[controller]")]
public class StateController : ControllerBase
{
  private readonly ParkLookupContext _db;
  public StateController(ParkLookupContext db)
  {
    _db = db;
  }

  [HttpGet("Park")]
  public async Task<ActionResult<List<State>>> Get()
  {
    return await _db.States.Include(s => s.Parks).ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<List<StatePark>>> GetParks(int id)
  {
    State state = await _db.States.FindAsync(id);

    if (state == null)
    {
      return NotFound();
    }

    List<StatePark> parks = await _db.StateParks
      .Where(sp => sp.StateId == id)
    .ToListAsync();

    return parks;
  }

  [Authorize]
  [HttpPost("Park")]
  public async Task<ActionResult<StatePark>> Post(StatePark park)
  {
    _db.StateParks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetParks), new { id = park.StateParkId }, park);
  }

  private bool ParkExists(int id)
  {
    return _db.StateParks.Any(park => park.StateParkId == id);
  }
  [Authorize]
  [HttpPut("Park/{id}")]
  public async Task<IActionResult> Put(int id, StatePark park)
  {
    if (id != park.StateParkId)
    {
      return BadRequest();
    }

    _db.StateParks.Update(park);

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
    StatePark park = await _db.StateParks.FindAsync(id);
    if (park == null)
    {
      return NotFound();
    }
    _db.StateParks.Remove(park);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}