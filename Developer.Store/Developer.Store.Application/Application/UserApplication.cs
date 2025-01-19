using Developer.Store.Application.Interface;
using Developer.Store.Commands.User;
using Developer.Store.Data.Domain.Tables;
using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Application
{
    public  class UserApplication : IUserApplication
    {
        private readonly IMediator _mediator;
        public UserApplication(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<UserResponse> Login(LoginRequest Login)
            => await _mediator.Send(new UserRequestLoginCommand(Login));

        public async Task<UserResponse> GetUser(int Id)
            => await _mediator.Send(new UserRequestGetCommand(Id));

        public async Task<List<UserResponse>> GetUsers(int Page, int Size)
            => await _mediator.Send(new UserRequestGetListCommand(Page, Size));

        public async Task<UserResponse> RegisterUser(UserRequest User)
            => await _mediator.Send(new UserRequestPostCommand(User));

        public async Task<UserResponse> AlterUser(UserRequest User, int Id)
            => await _mediator.Send(new UserRequestPutCommand(User,Id));

        public async Task<UserResponse> DeleteUser(int Id)
            => await _mediator.Send(new UserRequestDeleteCommand(Id));
    }
}
