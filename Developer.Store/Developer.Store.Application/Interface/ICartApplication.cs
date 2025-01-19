using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Interface
{
    public interface ICartApplication
    {
        Task<CartResponse> GetCart(int Id);
        Task<List<CartResponse>> GetCarts(int Page, int Size);
        Task<CartResponse> RegisterCart(CartRequest Cart);
        Task<CartResponse> AlterCart(CartRequest Cart, int Id);
        Task<CartResponse> DeleteCart(int Id);
    }
}
