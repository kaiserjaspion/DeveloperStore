using AutoMapper;
using Developer.Store.Data.Contexts;
using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Sale;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public SaleRepository(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<SaleResponse> GetSale(int Id)
        {
            var data = await _context.Sales.Where(x => x.Id == Id).FirstAsync();
            return _mapper.Map<SaleResponse>(data);
        }

        public async Task<List<SaleResponse>> GetSales(int Page, int Size)
        {
            var data = await _context.Sales.Skip(Page * Size).Take(Size).ToListAsync();
            return _mapper.Map<IReadOnlyList<SaleResponse>>(data).ToList();
        }

        public async Task<SaleResponse> RegisterSale(SaleRequest Sale)
        {
            var SaleDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Sale>(Sale);
            _context.Sales.Add(SaleDto);
            _context.SaveChanges();
            return _mapper.Map<SaleResponse>(SaleDto);
        }

        public async Task<SaleResponse> AlterSale(SaleRequest Sale, int Id)
        {
            var SaleDto = _mapper.Map<Developer.Store.Data.Domain.Tables.Sale>(Sale);
            SaleDto.Id = Id;
            _context.Sales.Update(SaleDto);
            _context.SaveChanges();
            return _mapper.Map<SaleResponse>(SaleDto);
        }

        public async Task<SaleResponse> DeleteSale(int Id)
        {
            var data = await _context.Sales.Where(x => x.Id == Id).FirstAsync();
            _context.Sales.Remove(data);
            return _mapper.Map<SaleResponse>(data);
        }
    }
}
