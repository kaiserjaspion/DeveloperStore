using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Product
{
    public class ProductRequestPutCommand : IRequest<ProductResponse>
    {
        public ProductRequest Product { get; private set; }
        public int Id { get; private set; }
        public ProductRequestPutCommand(ProductRequest product, int id)
        {
            Product = product;
            Id = id;
        }
    }
}
