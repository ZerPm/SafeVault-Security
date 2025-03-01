using Microsoft.AspNetCore.Mvc;
using SafeVault.Web.Services;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    public UserController()
    {
        _userService = new UserService();
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] UserRegisterRequest request)
    {
        if (_userService.CreateUser(request.Username, request.Password))
            return Ok("Usuario creado exitosamente");
        return BadRequest("Error al crear usuario");
    }
}

public class UserRegisterRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
