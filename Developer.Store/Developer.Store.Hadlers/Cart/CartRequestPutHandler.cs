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
    public class CartRequestPutHandler : IRequestHandler<CartRequestPutCommand, CartResponse>
    {
        private readonly ICartService _CartService;
        public CartRequestPutHandler(ICartService CartService) : base()
        {
            _CartService = CartService;
        }
        Task<CartResponse> IRequestHandler<CartRequestPutCommand, CartResponse>.Handle(CartRequestPutCommand request, CancellationToken cancellationToken)
        {
            var CartId = _CartService.AlterCart(request.Cart, request.Id);
            return CartId;
        }
    }
}
