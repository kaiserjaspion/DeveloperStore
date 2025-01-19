using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;

namespace Developer.Store.Hadlers.User
{
    public class UserRequestPostHandler : IRequestHandler<UserRequestPostCommand, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestPostHandler(IUserService userService) : base()
        {
            _userService = userService;
        }

        Task<UserResponse> IRequestHandler<UserRequestPostCommand, UserResponse>.Handle(UserRequestPostCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.RegisterUser(request.User);
            return userId;
        }

        
    }
}
