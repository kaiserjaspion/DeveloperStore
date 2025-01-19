using Developer.Store.Application.Interface;
using Developer.Store.Commands.Cart;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;
using MediatR;

namespace Developer.Store.Application.Application
{
    public class CartApplication : ICartApplication
    {
        private readonly IMediator _mediator;
        public CartApplication(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<CartResponse> GetCart(int Id)
            => await _mediator.Send(new CartRequestGetCommand(Id));
        public async Task<List<CartResponse>> GetCarts(int Page, int Size)
            => await _mediator.Send(new CartRequestGetListCommand(Page, Size));
        public async Task<CartResponse> RegisterCart(CartRequest Cart)
            => await _mediator.Send(new CartRequestPostCommand(Cart));
        public async Task<CartResponse> AlterCart(CartRequest Cart, int Id)
            => await _mediator.Send(new CartRequestPutCommand(Cart, Id));
        public async Task<CartResponse> DeleteCart(int Id)
            => await _mediator.Send(new CartRequestDeleteCommand(Id));
    }
}
