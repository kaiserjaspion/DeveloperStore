using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Sale;
using Developer.Store.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Services.Services
{
    public class SaleService: ISaleService
    {
        private readonly ISaleRepository _repository;
        public SaleService(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<SaleResponse> GetSale(int Id)
            => await _repository.GetSale(Id);

        public async Task<List<SaleResponse>> GetSales(int Page, int Size)
            => await _repository.GetSales(Page, Size);

        public async Task<SaleResponse> RegisterSale(SaleRequest Sale)
        {
            foreach (var item in Sale.SaleProducts)
            {
                var multiplier = 1.00;
                if (item.Quantity >= 10 && item.Quantity <= 20) multiplier = 0.80;
                else if (item.Quantity > 4 && item.Quantity < 10) multiplier = 0.90;
                var totalAmount = ((item.UnitPrice * item.Quantity) * (decimal)multiplier);
                item.TotalAmountItem = totalAmount;

                Sale.TotalAmount = Sale.TotalAmount + totalAmount;
            }

            return await _repository.RegisterSale(Sale);
        }

        public async Task<SaleResponse> AlterSale(SaleRequest Sale, int Id)
        {
            foreach (var item in Sale.SaleProducts) 
            {
                var multiplier = 1.00;
                if (item.Quantity >= 10 && item.Quantity <= 20) multiplier = 0.80;
                else if (item.Quantity > 4 && item.Quantity < 10) multiplier = 0.90;
                var totalAmount = ((item.UnitPrice * item.Quantity) * (decimal)multiplier);
                item.TotalAmountItem = totalAmount;

                Sale.TotalAmount = Sale.TotalAmount + totalAmount;
            }

            return await _repository.AlterSale(Sale, Id);
        }

        public async Task<SaleResponse> DeleteSale(int Id)
            => await _repository.DeleteSale(Id);
    }
}
