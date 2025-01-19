using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.User
{
    public class UserRequestGetCommand : IRequest<UserResponse>
    {
        public int Id { get; private set; }
        public UserRequestGetCommand(int id)
        {
            Id = id;
        }
    }
}
