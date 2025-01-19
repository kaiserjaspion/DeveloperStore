using Developer.Store.Application.Interface;
using Developer.Store.Commands.Sale;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Sale;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Application
{
    public class SaleApplication : ISaleApplication
    {
        private readonly IMediator _mediator;
        public SaleApplication(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<SaleResponse> GetSale(int Id)
            => await _mediator.Send(new SaleRequestGetCommand(Id));
        public async Task<List<SaleResponse>> GetSales(int Page, int Size)
            => await _mediator.Send(new SaleRequestGetListCommand(Page, Size));
        public async Task<SaleResponse> RegisterSale(SaleRequest Sale)
            => await _mediator.Send(new SaleRequestPostCommand(Sale));
        public async Task<SaleResponse> AlterSale(SaleRequest Sale, int Id)
            => await _mediator.Send(new SaleRequestPutCommand(Sale, Id));
        public async Task<SaleResponse> DeleteSale(int Id)
            => await _mediator.Send(new SaleRequestDeleteCommand(Id));
    }
}
