using Microsoft.AspNetCore.Mvc;
using MLA.Portal.Application.DTOs;
using MLA.Portal.Application.Interfaces;

namespace MLA.Portal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var result = await _authService.LoginAsync(request);
        if (result == null)
        {
            return Unauthorized(new { Message = "Invalid email or password" });
        }
        return Ok(result);
    }
}
