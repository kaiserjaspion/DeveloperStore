using Developer.Store.Commands.Sale;
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
    public class SaleRequestGetHandler : IRequestHandler<SaleRequestGetCommand, SaleResponse>
    {
        private readonly ISaleService _SaleService;
        public SaleRequestGetHandler(ISaleService SaleService) : base()
        {
            _SaleService = SaleService;
        }
        Task<SaleResponse> IRequestHandler<SaleRequestGetCommand, SaleResponse>.Handle(SaleRequestGetCommand request, CancellationToken cancellationToken)
        {
            var userId = _SaleService.GetSale(request.Id);
            return userId;
        }
    }
}
