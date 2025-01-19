using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;

namespace Developer.Store.Hadlers.User
{
    public class UserRequestPutHandler : IRequestHandler<UserRequestPutCommand, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestPutHandler(IUserService userService) : base()
        {
            _userService = userService;
        }
        Task<UserResponse> IRequestHandler<UserRequestPutCommand, UserResponse>.Handle(UserRequestPutCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.AlterUser(request.User,request.Id);
            return userId;
        }
    }
}
