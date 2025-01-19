using Developer.Store.Data.Domain.Tables;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace Developer.Store.Data.Contexts
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UsersAddresses { get; set; }
        public DbSet<UserName> UsersNames { get; set; }
        public DbSet<AddressGeolocation> AddressGeolocations { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
