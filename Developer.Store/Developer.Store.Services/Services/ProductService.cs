using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using Developer.Store.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductResponse> GetProduct(int Id)
            => await _repository.GetProduct(Id);

        public async Task<List<ProductResponse>> GetProducts(int Page, int Size)
            => await _repository.GetProducts(Page, Size);

        public async Task<ProductResponse> RegisterProduct(ProductRequest Product)
            => await _repository.RegisterProduct(Product);

        public async Task<ProductResponse> AlterProduct(ProductRequest Product, int Id)
            => await _repository.AlterProduct(Product, Id);

        public async Task<ProductResponse> DeleteProduct(int Id)
            => await _repository.DeleteProduct(Id);
        public async Task<List<ProductResponse>> GetProductCategories(string category, int Page, int Size)
            => await _repository.GetProductCategories(category,Page,Size);

    }
}
