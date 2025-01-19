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
    public class SaleRequestGetCommand : IRequest<SaleResponse>
    {
        public int Id { get; private set; }
        public SaleRequestGetCommand(int id)
        {
            Id = id;
        }
    }
}
