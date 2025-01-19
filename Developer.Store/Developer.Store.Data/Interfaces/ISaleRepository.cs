using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Interfaces
{
    public interface ISaleRepository
    {
        Task<SaleResponse> GetSale(int Id);
        Task<List<SaleResponse>> GetSales(int Page, int Size);
        Task<SaleResponse> RegisterSale(SaleRequest Sale);
        Task<SaleResponse> AlterSale(SaleRequest Sale, int Id);
        Task<SaleResponse> DeleteSale(int Id);
    }
}
