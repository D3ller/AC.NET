using Microsoft.AspNetCore.Mvc;
using real.Data;
using real.Mappers;

namespace real.Controllers;

[Microsoft.AspNetCore.Components.Route("/api/track")]
[ApiController]
public class TrackController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public TrackController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public IActionResult GetTrack([FromRoute] Guid id)
    {
        var track = _context.Tracks.Find(id);

        if (track == null || !track.IsVisible)
        {
            return NotFound();
        }

        return Ok(track.GetTrack());
    }
}