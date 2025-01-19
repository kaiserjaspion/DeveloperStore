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
    public class UserRequestGetHandler : IRequestHandler<UserRequestGetCommand, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestGetHandler(IUserService userService) : base()
        {
            _userService = userService;
        }
        Task<UserResponse> IRequestHandler<UserRequestGetCommand, UserResponse>.Handle(UserRequestGetCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.GetUser( request.Id);
            return userId;
        }
    }
}
