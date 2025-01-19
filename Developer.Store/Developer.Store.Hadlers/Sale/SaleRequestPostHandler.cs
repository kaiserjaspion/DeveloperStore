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
    public class SaleRequestPostHandler : IRequestHandler<SaleRequestPostCommand, SaleResponse>
    {
        private readonly ISaleService _SaleService;
        public SaleRequestPostHandler(ISaleService SaleService) : base()
        {
            _SaleService = SaleService;
        }

        Task<SaleResponse> IRequestHandler<SaleRequestPostCommand, SaleResponse>.Handle(SaleRequestPostCommand request, CancellationToken cancellationToken)
        {
            var SaleId = _SaleService.RegisterSale(request.Sale);
            return SaleId;
        }

    }
}
