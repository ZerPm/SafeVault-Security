using Microsoft.AspNetCore.Mvc;
using SafeVault.Web.Services;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;
    public AuthController()
    {
        _authService = new AuthService();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (_authService.Authenticate(request.Username, request.Password))
            return Ok("Login exitoso");
        return Unauthorized("Credenciales incorrectas");
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
