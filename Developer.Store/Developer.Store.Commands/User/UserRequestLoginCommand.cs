using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Response.User;
using MediatR;

namespace Developer.Store.Commands.User
{
    public class UserRequestLoginCommand : IRequest<UserResponse>
    {
        public LoginRequest Login { get; private set; }
        public UserRequestLoginCommand(LoginRequest login)
        {
           Login = login;
        }
    }
}
