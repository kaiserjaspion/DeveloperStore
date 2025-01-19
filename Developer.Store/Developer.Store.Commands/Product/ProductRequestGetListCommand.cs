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
    public class ProductRequestGetListCommand : IRequest<List<ProductResponse>>
    {
        public int Page { get; private set; }
        public int Size { get; private set; }
        public ProductRequestGetListCommand(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}
