using Developer.Store.Domain.Response.Product;
using Developer.Store.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Product
{
    public class ProductRequestDeleteCommand : IRequest<ProductResponse>
    {
        public int Id { get; private set; }
        public ProductRequestDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
