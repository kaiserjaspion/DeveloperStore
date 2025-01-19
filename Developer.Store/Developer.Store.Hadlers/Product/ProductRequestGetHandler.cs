using Developer.Store.Commands.Product;
using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.Product;
using Developer.Store.Domain.Response.User;
using Developer.Store.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Hadlers.Product
{
    public class ProductRequestGetHandler : IRequestHandler<ProductRequestGetCommand, ProductResponse>
    {
        private readonly IProductService _productService;
        public ProductRequestGetHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<ProductResponse> IRequestHandler<ProductRequestGetCommand, ProductResponse>.Handle(ProductRequestGetCommand request, CancellationToken cancellationToken)
        {
            var ProducId = _productService.GetProduct(request.Id);
            return ProducId;
        }
    }
}
