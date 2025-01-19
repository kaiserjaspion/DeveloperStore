using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Services.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;
        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }

        public async Task<CartResponse> GetCart(int Id)
            => await _repository.GetCart(Id);

        public async Task<List<CartResponse>> GetCarts(int Page, int Size)
            => await _repository.GetCarts(Page, Size);

        public async Task<CartResponse> RegisterCart(CartRequest Cart)
            => await _repository.RegisterCart(Cart);

        public async Task<CartResponse> AlterCart(CartRequest Cart, int Id)
            => await _repository.AlterCart(Cart, Id);

        public async Task<CartResponse> DeleteCart(int Id)
            => await _repository.DeleteCart(Id);

    }
}
