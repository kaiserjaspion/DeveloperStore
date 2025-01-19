using AutoMapper;
using Developer.Store.Data.Contexts;
using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<ProductResponse> GetProduct(int Id)
        {
            var data = await _context.Products.Where(x => x.Id == Id).FirstAsync();
            return _mapper.Map<ProductResponse>(data);
        }

        public async Task<List<ProductResponse>> GetProducts(int Page, int Size)
        {
            var data = await _context.Products.Skip(Page * Size).Take(Size).ToListAsync();
            return _mapper.Map<IReadOnlyList<ProductResponse>>(data).ToList();
        }

        public async Task<ProductResponse> RegisterProduct(ProductRequest Product)
        {
            var ProductDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Products>(Product);
            _context.Products.Add(ProductDto);
            _context.SaveChanges();
            return _mapper.Map<ProductResponse>(ProductDto);
        }

        public async Task<ProductResponse> AlterProduct(ProductRequest Product, int Id)
        {
            var ProductDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Products>(Product);
            ProductDto.Id = Id;
            _context.Products.Update(ProductDto);
            _context.SaveChanges();
            return _mapper.Map<ProductResponse>(ProductDto);
        }

        public async Task<ProductResponse> DeleteProduct(int Id)
        {
            var data = await _context.Products.Where(x => x.Id == Id).FirstAsync();
            _context.Products.Remove(data);
            return _mapper.Map<ProductResponse>(data);
        }

        public async Task<List<ProductResponse>> GetProductCategories(string category, int Page, int Size)
        {
            var data = await _context.Products.Where(x => x.Category.Contains(category)).Skip(Page * Size).Take(Size).ToListAsync();
            return _mapper.Map<IReadOnlyList<ProductResponse>>(data).ToList();
        }
    }
}
