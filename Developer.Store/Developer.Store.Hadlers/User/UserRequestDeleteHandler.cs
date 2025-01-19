using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.User
{
    public class UserRequestDeleteHandler : IRequestHandler<UserRequestDeleteCommand, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestDeleteHandler(IUserService userService) : base()
        {
            _userService = userService;
        }
        Task<UserResponse> IRequestHandler<UserRequestDeleteCommand, UserResponse>.Handle(UserRequestDeleteCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.DeleteUser(request.Id);
            return userId;
        }
    }
}
