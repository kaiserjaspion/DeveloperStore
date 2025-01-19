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
    public class ProductRequestPostHandler : IRequestHandler<ProductRequestPostCommand, ProductResponse>
    {
        private readonly IProductService _productService;
        public ProductRequestPostHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<ProductResponse> IRequestHandler<ProductRequestPostCommand, ProductResponse>.Handle(ProductRequestPostCommand request, CancellationToken cancellationToken)
        {
            var productId = _productService.RegisterProduct(request.Product);
            return productId;
        }
    }
}
