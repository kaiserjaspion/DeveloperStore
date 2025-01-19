using Developer.Store.Application.Interface;
using Developer.Store.Data.Domain.Tables;
using Developer.Store.Domain.CommonResponses;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.Product;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Store.Server.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : Controller
    {
        private readonly IProductApplication _productApplication;
        public ProductController(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }
        [HttpGet]
        public async Task<IActionResult> ListProducts([FromHeader] int _page, [FromHeader] int _size)
        {
            try
            {
                return Ok(new ListResponse<List<ProductResponse>>
                {
                    Data = await _productApplication.GetProducts(_page,_size),
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
        public async Task<IActionResult> NewProduct([FromBody] ProductRequest Product)
        {
            try
            {
                return Ok(await _productApplication.RegisterProduct(Product));
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
        public async Task<IActionResult> GetProduct(int Id)
        {
            try
            {
                return Ok(await _productApplication.GetProduct(Id));
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
        public async Task<IActionResult> AlterProducts([FromBody] ProductRequest Product, [FromHeader] int Id)
        {
            try
            {
                return Ok(await _productApplication.AlterProduct(Product,Id));
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
        public async Task<IActionResult> DeleteProducts([FromHeader] int Id)
        {
            try
            {
                await _productApplication.DeleteProduct(Id);
                return Ok(new { Message = "Deleted Product" });
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

        [HttpGet("category/{Category}")]
        public async Task<IActionResult> GetCategoryProducts([FromHeader] int _page, [FromHeader] int _size, string Category)
        {
            try
            {
                return Ok(new ListResponse<List<ProductResponse>>
                {
                    Data = await _productApplication.GetProductsByCategory(Category,_page, _size),
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
    }
}
