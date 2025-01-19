using Developer.Store.Commands.Cart;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.Cart
{
    public class CartRequestPostHandler : IRequestHandler<CartRequestPostCommand, CartResponse>
    {
        private readonly ICartService _CartService;
        public CartRequestPostHandler(ICartService CartService) : base()
        {
            _CartService = CartService;
        }

        Task<CartResponse> IRequestHandler<CartRequestPostCommand, CartResponse>.Handle(CartRequestPostCommand request, CancellationToken cancellationToken)
        {
            var CartId = _CartService.RegisterCart(request.Cart);
            return CartId;
        }

    }
}
