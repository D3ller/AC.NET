using Microsoft.AspNetCore.Mvc;
using real.Data;
using real.Dtos.User;
using real.Mappers;

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

    [HttpGet("{id}")]
    public IActionResult GetUser([FromRoute] Guid id)
    {
        var user = _context.Users.Find(id);

        if (user == null)
        {
            return NotFound();
        }

        var userTransformed = user.ViewUserDto(); 

        return Ok(userTransformed);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserDto userRequest)

    {
        var userModel = userRequest.ToCreateUserDto();
        _context.Add(userModel);
        _context.SaveChanges();
        
        return CreatedAtAction(nameof(GetUser), new {id = userModel.Id}, userModel.ViewUserDto());
    }
}