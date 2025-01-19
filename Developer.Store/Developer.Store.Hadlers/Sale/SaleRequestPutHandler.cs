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
    internal class SaleRequestPutHandler : IRequestHandler<SaleRequestPutCommand, SaleResponse>
    {
        private readonly ISaleService _SaleService;
        public SaleRequestPutHandler(ISaleService SaleService) : base()
        {
            _SaleService = SaleService;
        }
        Task<SaleResponse> IRequestHandler<SaleRequestPutCommand, SaleResponse>.Handle(SaleRequestPutCommand request, CancellationToken cancellationToken)
        {
            var SaleId = _SaleService.AlterSale(request.Sale, request.Id);
            return SaleId;
        }
    }
}
