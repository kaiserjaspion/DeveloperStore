using Developer.Store.Application.Interface;
using Developer.Store.Domain.CommonResponses;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Sale;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Store.Server.Controllers
{
    [ApiController]
    [Route("sales")]
    public class SaleController : Controller
    {
        private readonly ISaleApplication _SaleApplication;
        public SaleController(ISaleApplication SaleApplication)
        {
            _SaleApplication = SaleApplication;
        }
        [HttpGet]
        public async Task<IActionResult> ListSales([FromHeader] int _page, [FromHeader] int _size)
        {
            try
            {
                return Ok(new ListResponse<List<SaleResponse>>
                {
                    Data = await _SaleApplication.GetSales(_page, _size),
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
        public async Task<IActionResult> NewSale([FromBody] SaleRequest Sale)
        {
            try
            {
                return Ok(await _SaleApplication.RegisterSale(Sale));
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
        public async Task<IActionResult> GetSale(int Id)
        {
            try
            {
                return Ok(await _SaleApplication.GetSale(Id));
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
        public async Task<IActionResult> AlterSale([FromBody] SaleRequest Sale, [FromHeader] int Id)
        {
            try
            {
                return Ok(await _SaleApplication.AlterSale(Sale, Id));
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
        public async Task<IActionResult> DeleteSale([FromHeader] int Id)
        {
            try
            {
                await _SaleApplication.DeleteSale(Id);
                return Ok(new { Message = "Deleted Sale" });
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
