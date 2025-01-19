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
    public class UserRequestGetListHandler : IRequestHandler<UserRequestGetListCommand, List<UserResponse>>
    {
        private readonly IUserService _userService;
        public UserRequestGetListHandler(IUserService userService) : base()
        {
            _userService = userService;
        }
        Task<List<UserResponse>> IRequestHandler<UserRequestGetListCommand, List<UserResponse>>.Handle(UserRequestGetListCommand request, CancellationToken cancellationToken)
        {
            var userId = _userService.GetUsers(request.Page,request.Size);
            return userId;
        }
    }
}
