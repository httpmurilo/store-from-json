using Library.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infra.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasKey(t => t.Id);

            builder.Entity<Request>().HasKey(t => t.Id);
            builder.Entity<Request>().HasMany(t => t.Itens).WithOne(t => t.Request);
            builder.Entity<Request>().HasOne(t => t.Register).WithOne(t => t.Request).HasForeignKey<Register>(t => t.Id).IsRequired();

            builder.Entity<ItemRequest>().HasKey(t => t.Id);
            builder.Entity<ItemRequest>().HasOne(t => t.Request);
            builder.Entity<ItemRequest>().HasOne(t => t.Product);

            builder.Entity<Register>().HasKey(t => t.Id);
            builder.Entity<Register>().HasOne(t => t.Request);

        }
    }
}