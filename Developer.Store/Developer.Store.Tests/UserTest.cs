using Bogus;
using Developer.Store.Data.Domain.Enums;
using Developer.Store.Domain.Request.User;
using Developer.Store.Services.Interfaces;
using NSubstitute;

namespace Developer.Store.Tests
{
    public class UserTest
    {
        private readonly IUserService _service;

        public UserTest()
        {
            _service = Substitute.For<IUserService>();
        }
        [Fact]
        public async void ListUsersTest()
        {
            Assert.NotNull(await _service.GetUsers(1,30));
        }

        [Fact]
        public async void NewUserTest()
        {
            var user = CreateUser();
            var result = await _service.RegisterUser(user);
            Assert.NotNull(result);
        }

        [Fact]
        public async void GetUserTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.GetUser(Id));
        }

        [Fact]
        public async void AlterUserTest()
        {
            var user = CreateUser();
            var Id = 1;
            Assert.NotNull(await _service.AlterUser(user,Id));
        }

        [Fact]
        public async void DeleteUserTest()
        {
            var Id = 1;
            Assert.NotNull(await _service.DeleteUser(Id));
        }


        private static UserRequest CreateUser()
        {
            var user = new Faker<UserRequest>("pt_BR")
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
            var userName = new Faker<UserNameRequest>("pt_BR")
                .RuleFor(p => p.Firstname, m => m.Person.FirstName)
                .RuleFor(p => p.Lastname, m => m.Person.LastName)
                .Generate();
            return userName;
        }

        private static UserAddressRequest CreateUserAddress()
        {
            var userAddress = new Faker<UserAddressRequest>("pt_BR")
                .RuleFor(p => p.City, m => m.Address.City())
                .RuleFor(p => p.Street, m => m.Address.StreetAddress())
                .RuleFor(p => p.Number, m => m.Address.BuildingNumber())
                .RuleFor(p => p.Zipcode, m => m.Address.ZipCode())
                .Generate();
            return userAddress;
        }
    }
}
