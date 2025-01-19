using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponse> GetProduct(int Id);
        Task<List<ProductResponse>> GetProducts(int Page, int Size);
        Task<ProductResponse> RegisterProduct(ProductRequest Product);
        Task<ProductResponse> AlterProduct(ProductRequest Product, int Id);
        Task<ProductResponse> DeleteProduct(int Id);
        Task<List<ProductResponse>> GetProductCategories(string category, int Page, int Size);
    }
}
