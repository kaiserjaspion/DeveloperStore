using Bogus;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Services.Interfaces;
using NSubstitute;

namespace Developer.Store.Tests
{
    public class ProductTest
    {
        private readonly IProductService _service;

        public ProductTest()
        {
            _service = Substitute.For<IProductService>(); 
        }
        [Fact]
        public async void ListProductsTest()
        {
            Assert.NotNull(await _service.GetProducts(1,30));
        }

        [Fact]
        public async void NewProductTest()
        {
            var product = CreateProduct();
            Assert.NotNull(await _service.RegisterProduct(product));
        }

        [Fact]
        public async void GetProductTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.GetProduct( Id));
        }

        [Fact]
        public async void AlterProductTest()
        {
            var product = CreateProduct();
            
            var Id = 1;
            Assert.NotNull(await _service.AlterProduct(product,Id));
        }

        [Fact]
        public async void DeleteProductTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.DeleteProduct(Id));
        }


        private static ProductRequest CreateProduct()
        {
            var product = new Faker<ProductRequest>("Pt-br")
                .RuleFor(p => p.Title, m => m.Commerce.ProductName())
                .RuleFor(p => p.Price, m => Convert.ToDecimal(m.Commerce.Price(1,100,2,"R$").Replace("R$","")))
                .RuleFor(p => p.Description, m => m.Commerce.ProductDescription())
                .RuleFor(p => p.Category, m => m.Commerce.Categories(1).First())
                .RuleFor(p => p.Image, m => m.Commerce.ProductDescription())
                .Generate();
            product.Rating = CreateProductRating();
            return product;
        }

        private static ProductRatingRequest CreateProductRating()
        {
            var productRating = new Faker<ProductRatingRequest>("Pt-br")
                .RuleFor(p => p.Count, m => m.Random.Int())
                .RuleFor(p => p.Rate, m => Convert.ToDecimal(m.Commerce.Price(1, 5, 2, "R$").Replace("R$", "")))
                .Generate();
            return productRating;
        }
    }
}
