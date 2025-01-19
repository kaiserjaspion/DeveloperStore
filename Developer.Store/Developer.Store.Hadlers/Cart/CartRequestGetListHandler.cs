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
    public class CartRequestGetListHandler : IRequestHandler<CartRequestGetListCommand, List<CartResponse>>
    {
        private readonly ICartService _CartService;
        public CartRequestGetListHandler(ICartService CartService) : base()
        {
            _CartService = CartService;
        }
        Task<List<CartResponse>> IRequestHandler<CartRequestGetListCommand, List<CartResponse>>.Handle(CartRequestGetListCommand request, CancellationToken cancellationToken)
        {
            var CartId = _CartService.GetCarts(request.Page, request.Size);
            return CartId;
        }
    }
}
