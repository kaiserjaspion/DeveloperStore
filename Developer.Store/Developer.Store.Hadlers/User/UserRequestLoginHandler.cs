using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;

namespace Developer.Store.Hadlers.User
{
    public class UserRequestLoginHandler : IRequestHandler<UserRequestLoginCommand, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestLoginHandler(IUserService userService) : base()
        {
            _userService = userService;
        }
        Task<UserResponse> IRequestHandler<UserRequestLoginCommand, UserResponse>.Handle(UserRequestLoginCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.Login(request.Login);
            return userId;
        }
    }
}
