using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Request.User;
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
    public class ProductRequestPostCommand : IRequest<ProductResponse>
    {
        public ProductRequest Product { get; private set; }
        public ProductRequestPostCommand(ProductRequest product)
        {
            Product = product;
        }
    }
}
