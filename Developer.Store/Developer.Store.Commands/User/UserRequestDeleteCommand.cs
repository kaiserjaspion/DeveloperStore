using Developer.Store.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.User
{
    public class UserRequestDeleteCommand : IRequest<UserResponse>
    {
        public int Id { get; private set; }
        public UserRequestDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
