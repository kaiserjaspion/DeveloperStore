using Developer.Store.Domain.Request.Cart;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.Sale;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Sale
{
    public class SaleRequestPostCommand : IRequest<SaleResponse>
    {
        public SaleRequest Sale { get; private set; }
        public SaleRequestPostCommand(SaleRequest sale)
        {
            Sale = sale;
        }
    }
}
