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
    public class SaleRequestGetListHandler : IRequestHandler<SaleRequestGetListCommand, List<SaleResponse>>
    {
        private readonly ISaleService _SaleService;
        public SaleRequestGetListHandler(ISaleService SaleService) : base()
        {
            _SaleService = SaleService;
        }
        Task<List<SaleResponse>> IRequestHandler<SaleRequestGetListCommand, List<SaleResponse>>.Handle(SaleRequestGetListCommand request, CancellationToken cancellationToken)
        {
            var SaleId = _SaleService.GetSales(request.Page, request.Size);
            return SaleId;
        }
    }
}
