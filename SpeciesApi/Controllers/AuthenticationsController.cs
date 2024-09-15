using Microsoft.AspNetCore.Mvc;
using SpeciesApi.Models;
using SpeciesApi.Services.Interfaces;

namespace AnimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationsController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationsController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User login)
        {
           
            if (_authService.ValidateUserCredentials(login))
            {
                var token = _authService.GenerateJwtToken(login.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
