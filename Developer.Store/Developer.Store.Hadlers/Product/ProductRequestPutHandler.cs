using Developer.Store.Commands.Product;
using Developer.Store.Domain.Response.Product;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.Product
{
    public class ProductRequestPutHandler : IRequestHandler<ProductRequestPutCommand, ProductResponse>
    {
        private readonly IProductService _productService;
        public ProductRequestPutHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<ProductResponse> IRequestHandler<ProductRequestPutCommand, ProductResponse>.Handle(ProductRequestPutCommand request, CancellationToken cancellationToken)
        {
            var productId = _productService.AlterProduct(request.Product,request.Id);
            return productId;
        }
    }
}
