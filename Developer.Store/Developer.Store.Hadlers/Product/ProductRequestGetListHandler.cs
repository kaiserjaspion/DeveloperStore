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
    public class ProductRequestGetListHandler : IRequestHandler<ProductRequestGetListCommand, List<ProductResponse>>
    {
        private readonly IProductService _productService;
        public ProductRequestGetListHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<List<ProductResponse>> IRequestHandler<ProductRequestGetListCommand, List<ProductResponse>>.Handle(ProductRequestGetListCommand request, CancellationToken cancellationToken)
        {
            var userId = _productService.GetProducts(request.Page, request.Size);
            return userId;
        }
    }
}
