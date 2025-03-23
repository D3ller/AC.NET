using Microsoft.AspNetCore.Mvc;
using real.Data;

namespace real.Controllers;

[Route("/api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    
    public UserController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList();

        return Ok(users);
    }

    [HttpGet("/{id}")]
    public IActionResult GetUser([FromRoute] Guid id)
    {
        var user = _context.Users.Find(id);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}