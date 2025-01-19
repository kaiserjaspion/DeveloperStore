using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Interface
{
    public interface IProductApplication
    {
        Task<ProductResponse> GetProduct(int Id);
        Task<List<ProductResponse>> GetProducts(int Page, int Size);
        Task<List<ProductResponse>> GetProductsByCategory(string category, int Page, int Size);
        Task<ProductResponse> RegisterProduct(ProductRequest Product);
        Task<ProductResponse> AlterProduct(ProductRequest Product, int Id);
        Task<ProductResponse> DeleteProduct(int Id);
    }
}
