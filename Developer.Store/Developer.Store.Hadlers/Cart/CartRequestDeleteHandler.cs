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
    public class CartRequestDeleteHandler : IRequestHandler<CartRequestDeleteCommand, CartResponse>
    {
        private readonly ICartService _CartService;
        public CartRequestDeleteHandler(ICartService CartService) : base()
        {
            _CartService = CartService;
        }
        Task<CartResponse> IRequestHandler<CartRequestDeleteCommand, CartResponse>.Handle(CartRequestDeleteCommand request, CancellationToken cancellationToken)
        {
            var CartId = _CartService.DeleteCart(request.Id);
            return CartId;
        }
    }
}
