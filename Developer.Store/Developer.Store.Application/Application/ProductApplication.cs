using Developer.Store.Application.Interface;
using Developer.Store.Commands.Product;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Response.Product;
using MediatR;

namespace Developer.Store.Application.Application
{
    public class ProductApplication  : IProductApplication
    {
        private readonly IMediator _mediator;
        public ProductApplication(IMediator mediator)
        {
            _mediator = mediator;
        }


        public async Task<ProductResponse> GetProduct(int Id)
            => await _mediator.Send(new ProductRequestGetCommand(Id));

        public async Task<List<ProductResponse>> GetProducts(int Page, int Size)
            => await _mediator.Send(new ProductRequestGetListCommand(Page, Size));

        public async Task<List<ProductResponse>> GetProductsByCategory(string category,int Page, int Size)
            => await _mediator.Send(new ProductRequestGetListCategoryCommand(category, Page, Size));

        public async Task<ProductResponse> RegisterProduct(ProductRequest Product)
            => await _mediator.Send(new ProductRequestPostCommand(Product));

        public async Task<ProductResponse> AlterProduct(ProductRequest Product, int Id)
            => await _mediator.Send(new ProductRequestPutCommand(Product, Id));

        public async Task<ProductResponse> DeleteProduct(int Id)
            => await _mediator.Send(new ProductRequestDeleteCommand(Id));
    }
}
