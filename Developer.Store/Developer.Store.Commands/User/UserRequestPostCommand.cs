using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using MediatR;

namespace Developer.Store.Commands.User
{
    public class UserRequestPostCommand : IRequest<UserResponse>
    {
        public UserRequest User { get; private set; }
        public UserRequestPostCommand(UserRequest user)
        {
            User = user;
        }
    }
}
