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

  [HttpGet]
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
}