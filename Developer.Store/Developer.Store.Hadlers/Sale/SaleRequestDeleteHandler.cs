using Developer.Store.Commands.Cart;
using Developer.Store.Commands.Sale;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.Sale;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.Sale
{
    public class SaleRequestDeleteHandler : IRequestHandler<SaleRequestDeleteCommand, SaleResponse>
    {
        private readonly ISaleService _SaleService;
        public SaleRequestDeleteHandler(ISaleService SaleService) : base()
        {
            _SaleService = SaleService;
        }
        Task<SaleResponse> IRequestHandler<SaleRequestDeleteCommand, SaleResponse>.Handle(SaleRequestDeleteCommand request, CancellationToken cancellationToken)
        {
            var CartId = _SaleService.DeleteSale(request.Id);
            return CartId;
        }
    }
}
