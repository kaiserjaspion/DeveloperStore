using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Request.User;
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
    public class CartRequestPutCommand : IRequest<CartResponse>
    {
        public CartRequest Cart { get; private set; }
        public int Id { get; private set; }
        public CartRequestPutCommand(CartRequest cart, int id)
        {
            Cart = cart;
            Id = id;
        }
    }
}
