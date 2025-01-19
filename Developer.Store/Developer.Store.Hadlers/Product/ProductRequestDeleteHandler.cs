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
    public class ProductRequestDeleteHandler : IRequestHandler<ProductRequestDeleteCommand, ProductResponse>
    {
        private readonly IProductService _productService;
        public ProductRequestDeleteHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<ProductResponse> IRequestHandler<ProductRequestDeleteCommand, ProductResponse>.Handle(ProductRequestDeleteCommand request, CancellationToken cancellationToken)
        {
            var productId = _productService.DeleteProduct( request.Id);
            return productId;
        }
    }
}
