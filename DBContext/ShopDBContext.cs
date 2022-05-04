using ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces;
using ASP.NET_CORE_6_REST_API_Shop_Example.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// To create migrations (entity framework) classes, tape in Package Manager: Add-Migration Shop_Example_DBSet
/// To set datebase, with 3 product ex. tape in Package Manager command: Update-Database
/// </summary>

namespace ASP.NET_CORE_6_REST_API_Shop_Example.DBContext
{
    public class ShopDBContext : DbContext, IShopDbContext
    {
        private readonly DbContextOptions _options;
        public ShopDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<ShopProduct>? ShopProducts { get; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopProduct>(eb =>
            {
                eb.HasKey(x => x.Id);
                eb.Property(x => x.Id).ValueGeneratedOnAdd();
                eb.Property(x => x.ProductName).HasColumnType("nvarchar(150)");
                eb.Property(x => x.ProductDescription).HasMaxLength(2000);
                eb.Property(x => x.ProductPrice).HasColumnType("Smallmoney");
                eb.Property(x => x.ProductCreationDate).HasColumnType("DateTimeOffset").HasDefaultValueSql("GETUTCDATE()");
                eb.Property(x => x.ProductModificationDate).HasColumnType("DateTimeOffset").HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<ShopProduct>().HasData(
                   new ShopProduct()
                   {
                       Id = Guid.NewGuid(),
                       ProductName = "Mobile Phone X",
                       ProductDescription = "Very Good and Quckly Phone, for alldays use.",
                       ProductPrice = 988.99m,
                   },
                   new ShopProduct()
                   {
                       Id = Guid.NewGuid(),
                       ProductName = "Chair Y",
                       ProductDescription = "Very Good and Comfortable Chair, for alldays use.",
                       ProductPrice = 189.99m,
                   },
                   new ShopProduct()
                   {
                       Id = Guid.NewGuid(),
                       ProductName = "Printer Z",
                       ProductDescription = "Very Good and Quckly Printer, for alldays use.",
                       ProductPrice = 85.99m,
                   }
            );
        } 
    }
}