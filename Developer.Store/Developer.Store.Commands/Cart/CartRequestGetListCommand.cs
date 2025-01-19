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
    public class CartRequestGetListCommand : IRequest<List<CartResponse>>
    {
        public int Page { get; private set; }
        public int Size { get; private set; }
        public CartRequestGetListCommand(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}
