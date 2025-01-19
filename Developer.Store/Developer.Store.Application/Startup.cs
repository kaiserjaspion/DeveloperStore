using Developer.Store.Application.Application;
using Developer.Store.Application.Interface;
using Developer.Store.Data.Interfaces;
using Developer.Store.Data.Repositories;
using Developer.Store.Services.Interfaces;
using Developer.Store.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Developer.Store.Application
{
    public static class Startup
    {
        public static void ConfigureApplicationDepencies(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISaleService, SaleService>();

            services.AddTransient<IAuthApplication,AuthApplication>();
            services.AddTransient<IUserApplication,UserApplication>();
            services.AddTransient<ICartApplication,CartApplication>();
            services.AddTransient<IProductApplication,ProductApplication>();
            services.AddTransient<ISaleApplication,SaleApplication>();
        }
    }
}
