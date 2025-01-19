using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;

namespace Developer.Store.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<UserResponse> Login(LoginRequest Login)
            => await _repository.Login(Login);

        public async Task<UserResponse> GetUser(int Id)
            => await _repository.GetUser(Id);

        public async Task<List<UserResponse>> GetUsers(int Page,int Size)
            => await _repository.GetUsers(Page,Size);

        public async Task<UserResponse> RegisterUser(UserRequest User)
            => await _repository.RegisterUser(User);

        public async Task<UserResponse> AlterUser(UserRequest User, int Id)
            => await _repository.AlterUser(User,Id);

        public async Task<UserResponse> DeleteUser(int Id)
            => await _repository.DeleteUser(Id);


    }
}
