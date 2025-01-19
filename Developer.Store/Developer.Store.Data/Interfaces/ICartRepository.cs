using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;

namespace Developer.Store.Data.Interfaces
{
    public interface ICartRepository
    {
        Task<CartResponse> GetCart(int Id);
        Task<List<CartResponse>> GetCarts(int Page, int Size);
        Task<CartResponse> RegisterCart(CartRequest Cart);
        Task<CartResponse> AlterCart(CartRequest Cart, int Id);
        Task<CartResponse> DeleteCart(int Id);
    }
}
