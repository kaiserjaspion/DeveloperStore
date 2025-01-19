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
    public class SaleRequestGetListCommand : IRequest<List<SaleResponse>>
    {
        public int Page { get; private set; }
        public int Size { get; private set; }
        public SaleRequestGetListCommand(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}
