using Bogus;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Services.Interfaces;
using NSubstitute;

namespace Developer.Store.Tests
{
    public class AuthTest
    {
        private readonly IUserService _service;

        public AuthTest()
        {
            _service = Substitute.For<IUserService>();
        }

        [Fact]
        public async void LoginTest()
        {
            var login = CreateCart();
            var user = await _service.Login(login);
            Assert.NotNull(user);
        }


        private static LoginRequest CreateCart()
        {
            var login = new Faker<LoginRequest>("Pt-br")
                .RuleFor(p => p.Username, m => m.Person.UserName)
                .RuleFor(p => p.Password, m => m.Internet.Password())
                .Generate();
            return login;
        }

    }
}
