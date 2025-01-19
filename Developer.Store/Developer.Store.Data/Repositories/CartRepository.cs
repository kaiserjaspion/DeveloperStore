using AutoMapper;
using Developer.Store.Data.Contexts;
using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Response.Cart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public CartRepository(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<CartResponse> GetCart(int Id)
        {
            var data = await _context.Carts.Where(x => x.Id == Id).FirstAsync();
            return _mapper.Map<CartResponse>(data);
        }

        public async Task<List<CartResponse>> GetCarts(int Page, int Size)
        {
            var data = await _context.Carts.Skip(Page * Size).Take(Size).ToListAsync();
            return _mapper.Map<IReadOnlyList<CartResponse>>(data).ToList();
        }

        public async Task<CartResponse> RegisterCart(CartRequest Cart)
        {
            var CartDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Cart>(Cart);
            _context.Carts.Add(CartDto);
            _context.SaveChanges();
            return _mapper.Map<CartResponse>(CartDto);
        }

        public async Task<CartResponse> AlterCart(CartRequest Cart, int Id)
        {
            var CartDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Cart>(Cart);
            CartDto.Id = Id;
            _context.Carts.Update(CartDto);
            _context.SaveChanges();
            return _mapper.Map<CartResponse>(CartDto);
        }

        public async Task<CartResponse> DeleteCart(int Id)
        {
            var data = await _context.Carts.Where(x => x.Id == Id).FirstAsync();
            _context.Carts.Remove(data);
            return _mapper.Map<CartResponse>(data);
        }
    }
}
