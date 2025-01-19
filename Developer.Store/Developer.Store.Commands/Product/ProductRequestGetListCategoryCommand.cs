using Developer.Store.Domain.Response.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Commands.Product
{
    public class ProductRequestGetListCategoryCommand : IRequest<List<ProductResponse>>
    {
        public int Page { get; private set; }
        public int Size { get; private set; }
        public string Category { get; private set; }
        public ProductRequestGetListCategoryCommand(string category,int page, int size)
        {
            Page = page;
            Size = size;
            Category = category;
        }
    }
}
