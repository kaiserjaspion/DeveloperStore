using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<UserResponse> Login(LoginRequest Login);
        Task<UserResponse> GetUser(int Id);
        Task<List<UserResponse>> GetUsers(int Page, int Size);
        Task<UserResponse> RegisterUser(UserRequest User);
        Task<UserResponse> AlterUser(UserRequest User, int Id);
        Task<UserResponse> DeleteUser(int Id);
    }
}
