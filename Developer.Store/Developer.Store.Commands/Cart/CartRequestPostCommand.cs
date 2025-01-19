using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;
using MediatR;

namespace Developer.Store.Commands.Cart
{
    public class CartRequestPostCommand : IRequest<CartResponse>
    {
        public CartRequest Cart { get; private set; }
        public CartRequestPostCommand(CartRequest cart)
        {
            Cart = cart;
        }
    }
}
