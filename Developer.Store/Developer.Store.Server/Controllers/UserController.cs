using Developer.Store.Application.Interface;
using Developer.Store.Data.Domain.Tables;
using Developer.Store.Domain.CommonResponses;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.User;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Store.Server.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {
        private readonly IUserApplication _userApplication;
        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }
        [HttpGet]
        public async Task<IActionResult> ListUsers([FromHeader] int _page, [FromHeader] int _size)
        {
            try
            {
                return Ok(new ListResponse<List<UserResponse>>
                {
                    Data = await _userApplication.GetUsers(_page,_size),
                    CurrentPage = _page,
                    TotalItens = 0,
                    TotalPages = 0
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = "",
                    Error = "",
                    Detail = ex.Message,
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewUser([FromBody] UserRequest User)
        {
            try
            {
                return Ok(await _userApplication.RegisterUser(User));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = "",
                    Error = "",
                    Detail = ex.Message,
                });
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUser(int Id)
        {
            try
            {
                return Ok(await _userApplication.GetUser(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = "",
                    Error = "",
                    Detail = ex.Message,
                });
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> AlterUser([FromBody] UserRequest User, [FromHeader] int Id)
        {
            try
            {
                return Ok(await _userApplication.AlterUser(User, Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = "",
                    Error = "",
                    Detail = ex.Message,
                });
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteUser([FromHeader] int Id)
        {
            try
            {
                await _userApplication.DeleteUser(Id);
                return Ok(new { Message = "Deleted User" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = "",
                    Error = "",
                    Detail = ex.Message,
                });
            }
        }
    }
}
