using Bogus;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Services.Interfaces;
using NSubstitute;

namespace Developer.Store.Tests
{
    public class CartTest
    {
        private readonly ICartService _service;

        public CartTest()
        {
            _service = Substitute.For<ICartService>();
        }
        [Fact]
        public async void ListCartsTest()
        {
            Assert.NotNull(await _service.GetCarts(1, 30));
        }

        [Fact]
        public async void NewCartTest()
        {
            var cart = CreateCart();
            Assert.NotNull(await _service.RegisterCart(cart));
        }

        [Fact]
        public async void GetCartTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.GetCart(Id));
        }

        [Fact]
        public async void AlterCartTest()
        {
            var cart = CreateCart();
            var Id = 1;
            Assert.NotNull(await _service.AlterCart(cart, Id));
        }

        [Fact]
        public async void DeleteCartTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.DeleteCart(Id));
        }

        private static CartRequest CreateCart()
        {
            var cart = new Faker<CartRequest>("Pt-br")
                .RuleFor(p => p.UserId,m => m.Random.Int())
                .RuleFor(p => p.Date, m => m.Date.Recent(100))
                .Generate();
            cart.products.Add(CreateCartProduct());
            return cart;
        }

        private static Developer.Store.Domain.Request.Cart.CartProduct CreateCartProduct()
        {
            var product = new Faker<Developer.Store.Domain.Request.Cart.CartProduct>("Pt-br")
                .RuleFor(p => p.ProductId, m => m.Random.Int())
                .RuleFor(p => p.Quantity, m => m.Random.Int())
                .Generate();
            return product;
        }
    }
}