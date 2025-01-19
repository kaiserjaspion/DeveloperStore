using Developer.Store.Commands.Cart;
using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.Cart
{
    public class CartRequestGetHandler : IRequestHandler<CartRequestGetCommand, CartResponse>
    {
        private readonly ICartService _cartService;
        public CartRequestGetHandler(ICartService cartService) : base()
        {
            _cartService = cartService;
        }
        Task<CartResponse> IRequestHandler<CartRequestGetCommand, CartResponse>.Handle(CartRequestGetCommand request, CancellationToken cancellationToken)
        {
            var userId = _cartService.GetCart(request.Id);
            return userId;
        }
    }
}
