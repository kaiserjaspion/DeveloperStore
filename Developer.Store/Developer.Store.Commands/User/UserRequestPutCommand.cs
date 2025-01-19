using Developer.Store.Data.Domain.Tables;
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
    public class UserRequestPutCommand : IRequest<UserResponse>
    {
        public UserRequest User { get; private set; }
        public int Id { get; private set; }
        public UserRequestPutCommand(UserRequest user,int id) 
        {
            User = user;
            Id = id;
        }
    }
}
