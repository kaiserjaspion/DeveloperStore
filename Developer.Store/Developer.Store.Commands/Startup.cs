using Developer.Store.Commands.Cart;
using Developer.Store.Commands.Product;
using Developer.Store.Commands.Sale;
using Developer.Store.Commands.User;
using Microsoft.Extensions.DependencyInjection;

namespace Developer.Store.Commands
{
    public class Startup
    {
        public static void ConfigureCommand(IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CartRequestDeleteCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CartRequestGetCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CartRequestPostCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CartRequestGetListCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CartRequestPutCommand).Assembly));

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestPutCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestPostCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestGetListCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestGetListCategoryCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestGetCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ProductRequestDeleteCommand).Assembly));

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestPutCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestPostCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestLoginCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestGetListCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestGetCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(UserRequestDeleteCommand).Assembly));

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(SaleRequestDeleteCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(SaleRequestGetCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(SaleRequestPostCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(SaleRequestGetListCommand).Assembly));
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(SaleRequestPutCommand).Assembly));
        }
    }
}
