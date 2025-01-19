using Developer.Store.Commands.Cart;
using Developer.Store.Commands.Product;
using Developer.Store.Commands.Sale;
using Developer.Store.Commands.User;
using Developer.Store.Domain.Response.Cart;
using Developer.Store.Domain.Response.Product;
using Developer.Store.Domain.Response.Sale;
using Developer.Store.Domain.Response.User;
using Developer.Store.Hadlers.Cart;
using Developer.Store.Hadlers.Product;
using Developer.Store.Hadlers.Sale;
using Developer.Store.Hadlers.User;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Developer.Store.Hadlers
{
    public class Startup
    {
        public static void ConfuigureHandler(IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<CartRequestDeleteCommand, CartResponse>, CartRequestDeleteHandler>();
            services.AddTransient<IRequestHandler<CartRequestGetCommand, CartResponse>, CartRequestGetHandler>();
            services.AddTransient<IRequestHandler<CartRequestPutCommand, CartResponse>, CartRequestPutHandler>();
            services.AddTransient<IRequestHandler<CartRequestPostCommand, CartResponse>, CartRequestPostHandler>();
            services.AddTransient<IRequestHandler<CartRequestGetListCommand, List<CartResponse>>, CartRequestGetListHandler>();


            services.AddTransient<IRequestHandler<ProductRequestPutCommand, ProductResponse>, ProductRequestPutHandler>();
            services.AddTransient<IRequestHandler<ProductRequestPostCommand, ProductResponse>, ProductRequestPostHandler>();
            services.AddTransient<IRequestHandler<ProductRequestGetListCommand, List<ProductResponse>>, ProductRequestGetListHandler>();
            services.AddTransient<IRequestHandler<ProductRequestGetListCategoryCommand, List<ProductResponse>>, ProductRequestGetListCategoryHandler>();
            services.AddTransient<IRequestHandler<ProductRequestGetCommand, ProductResponse>, ProductRequestGetHandler>();
            services.AddTransient<IRequestHandler<ProductRequestDeleteCommand, ProductResponse>, ProductRequestDeleteHandler>();

            services.AddTransient<IRequestHandler<UserRequestPutCommand, UserResponse>, UserRequestPutHandler>();
            services.AddTransient<IRequestHandler<UserRequestPostCommand, UserResponse>, UserRequestPostHandler>();
            services.AddTransient<IRequestHandler<UserRequestLoginCommand, UserResponse>, UserRequestLoginHandler>();
            services.AddTransient<IRequestHandler<UserRequestGetListCommand, List<UserResponse>>, UserRequestGetListHandler>();
            services.AddTransient<IRequestHandler<UserRequestGetCommand, UserResponse>, UserRequestGetHandler>();
            services.AddTransient<IRequestHandler<UserRequestDeleteCommand, UserResponse>, UserRequestDeleteHandler>();

            services.AddTransient<IRequestHandler<SaleRequestDeleteCommand, SaleResponse>, SaleRequestDeleteHandler>();
            services.AddTransient<IRequestHandler<SaleRequestGetCommand, SaleResponse>, SaleRequestGetHandler>();
            services.AddTransient<IRequestHandler<SaleRequestPutCommand, SaleResponse>, SaleRequestPutHandler>();
            services.AddTransient<IRequestHandler<SaleRequestPostCommand, SaleResponse>, SaleRequestPostHandler>();
            services.AddTransient<IRequestHandler<SaleRequestGetListCommand, List<SaleResponse>>, SaleRequestGetListHandler>();
        }
    }
}
