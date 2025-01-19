using Developer.Store.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.User
{
    public class UserRequestGetListCommand : IRequest<List<UserResponse>>
    {
        public int Page {  get; private set; }
        public int Size { get; private set; }
        public UserRequestGetListCommand(int page,int size)
        {
            Page = page;
            Size = size;
        }
    }
}
