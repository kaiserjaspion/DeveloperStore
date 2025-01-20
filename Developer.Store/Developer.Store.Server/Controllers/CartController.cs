using Developer.Store.Application.Application;
using Developer.Store.Application.Interface;
using Developer.Store.Data.Domain.Tables;
using Developer.Store.Domain.CommonResponses;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Store.Server.Controllers
{
    [ApiController]
    [Route("carts")]
    public class CartController : Controller
    {
        private readonly  ICartApplication _cartApplication;
        public CartController(ICartApplication cartApplication)
        {
            _cartApplication = cartApplication; 
        }
        [HttpGet]
        public async Task<IActionResult> ListCarts([FromHeader]int _page, [FromHeader]int _size)
        {
            try
            {
                return Ok( new ListResponse<List<CartResponse>> { 
                    Data = await _cartApplication.GetCarts(_page,_size),
                    CurrentPage = _page,
                    TotalItens = 0,
                    TotalPages = 0
                });
            }
            catch (Exception ex) 
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewCart([FromBody] CartRequest cart)
        {
            try
            {
                return Ok(await _cartApplication.RegisterCart(cart));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCart(int Id)
        {
            try
            {
                return Ok(await _cartApplication.GetCart(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> AlterCart([FromBody] CartRequest cart, [FromHeader] int Id)
        {
            try
            {
                return Ok(await _cartApplication.AlterCart(cart,Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCart([FromHeader] int Id)
        {
            try
            {
                await _cartApplication.DeleteCart(Id);
                return Ok(new { Message =  "Deleted Cart"});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Type = ex.GetType().ToString(),
                    Error = ex.Message,
                    Detail = ex.InnerException.Message,
                });
            }
        }
    }
}
