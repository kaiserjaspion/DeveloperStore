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
    public class ProductRequestGetListCategoryHandler : IRequestHandler<ProductRequestGetListCategoryCommand, List<ProductResponse>>
    {
        private readonly IProductService _productService;
        public ProductRequestGetListCategoryHandler(IProductService productService) : base()
        {
            _productService = productService;
        }
        Task<List<ProductResponse>> IRequestHandler<ProductRequestGetListCategoryCommand, List<ProductResponse>>.Handle(ProductRequestGetListCategoryCommand request, CancellationToken cancellationToken)
        {
            var userId = _productService.GetProductCategories(request.Category,request.Page, request.Size);
            return userId;
        }
    }
}
