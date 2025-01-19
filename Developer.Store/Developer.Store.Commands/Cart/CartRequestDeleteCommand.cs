using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Cart
{
    public class CartRequestDeleteCommand : IRequest<CartResponse>
    {
        public int Id { get; private set; }
        public CartRequestDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
