using ASP.NET_CORE_6_REST_API_Shop_Example.Models;
using Microsoft.EntityFrameworkCore; 

namespace ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces
{
    public interface IShopDbContext
    {
        DbSet<ShopProduct>? ShopProducts { get; set; }
        Task<int> SaveChanges();
    }
}
