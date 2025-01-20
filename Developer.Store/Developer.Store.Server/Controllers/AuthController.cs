using Developer.Store.Application.Interface;
using Developer.Store.Domain.CommonResponses;
using Developer.Store.Domain.Reequest.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Store.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthApplication _application;
        public AuthController(IAuthApplication application)
        {
            _application = application;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            try
            {
                return Ok(new { token = await _application.CreateToken(login) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }

    }
}
