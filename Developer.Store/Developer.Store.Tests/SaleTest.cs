using Bogus;
using Developer.Store.Data.Domain.Enums;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using NSubstitute;

namespace Developer.Store.Tests
{
    public class SaleTest
    {
        private readonly ISaleService _service;

        public SaleTest()
        {
            _service = Substitute.For<ISaleService>();
        }
        [Fact]
        public async void ListSalesTest()
        {
            Assert.NotNull(await _service.GetSales(1,30));
        }

        [Fact]
        public async void NewSaleTest()
        {
            var sale = CreateSale();
            Assert.NotNull(await _service.RegisterSale(sale));
        }

        [Fact]
        public async void GetSaleTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.GetSale(Id));
        }

        [Fact]
        public async void AlterSaleTest()
        {

            var sale = CreateSale();
            var Id = 1;
            Assert.NotNull(await _service.AlterSale(sale,Id));
        }

        [Fact]
        public async void DeleteSaleTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.DeleteSale(Id));
        }


        private static SaleRequest CreateSale()
        {
            var sale = new Faker<SaleRequest>("Pt-br")
                .RuleFor(p => p.Date, m => m.Date.Recent(100))
                .RuleFor(p => p.UserId, m => m.Random.Int())
                .RuleFor(p => p.TotalAmount, m => Convert.ToDecimal(m.Commerce.Price(1, 10000, 2, "R$").Replace("R$", "")))
                .RuleFor(p => p.Branch, m => m.Company.CompanyName())
                .RuleFor(p => p.Canceled, m => false)
                .Generate();
            sale.User = CreateUser();
            sale.SaleProducts.Add(CreateSaleProducts());
            return sale;
        }


        private static UserResponse CreateUser()
        {
            var user = new Faker<UserResponse>("Pt-br")
                .RuleFor(p => p.Email, m => m.Person.Email)
                .RuleFor(p => p.Username, m => m.Person.UserName)
                .RuleFor(p => p.Password, m => m.Internet.Password())
                .RuleFor(p => p.Phone, m => m.Person.Phone)
                .RuleFor(p => p.Status, m => UserStatus.Active)
                .RuleFor(p => p.Role, m => UserRoles.Customer)
                .Generate();
            user.Address = CreateUserAddress();
            user.Name = CreateUserName();
            return user;
        }

        private static UserNameRequest CreateUserName()
        {
            var userName = new Faker<UserNameRequest>("Pt-br")
                .RuleFor(p => p.Firstname, m => m.Person.FirstName)
                .RuleFor(p => p.Lastname, m => m.Person.LastName)
                .Generate();
            return userName;
        }

        private static UserAddressRequest CreateUserAddress()
        {
            var userAddress = new Faker<UserAddressRequest>("Pt-br")
                .RuleFor(p => p.City, m => m.Address.City())
                .RuleFor(p => p.Street, m => m.Address.StreetAddress())
                .RuleFor(p => p.Number, m => m.Address.BuildingNumber())
                .RuleFor(p => p.Zipcode, m => m.Address.ZipCode())
                .Generate();
            return userAddress;
        }

        private static SaleProductRequest CreateSaleProducts()
        {
            var saleProduct = new Faker<SaleProductRequest>("Pt-br")
                .RuleFor(p => p.Id, m => m.Random.Int())
                .RuleFor(p => p.SaleId, m => m.Random.Int())
                .RuleFor(p => p.ProductId, m => m.Random.Int())
                .RuleFor(p => p.Quantity, m => m.Random.Int())
                .RuleFor(p => p.UnitPrice, m => Convert.ToDecimal(m.Commerce.Price(1, 10000, 2, "R$").Replace("R$", "")))
                .RuleFor(p => p.Discount, m => (decimal)1.0)
                .RuleFor(p => p.TotalAmountItem, 0)
                .RuleFor(p => p.Canceled, m => false)
                .Generate();
            return saleProduct;
        }
    }
}
