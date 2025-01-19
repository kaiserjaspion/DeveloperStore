using Developer.Store.Domain.Response.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Product
{
    public class ProductRequestGetCommand : IRequest<ProductResponse>
    {
        public int Id { get; private set; }
        public ProductRequestGetCommand(int id)
        {
            Id = id;
        }
        
    }
}
