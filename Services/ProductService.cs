using ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces; 
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CORE_6_REST_API_Shop_Example.Services
{
    public class ProductService<TDbContext> : IProductService where TDbContext : DbContext
    {
        protected TDbContext dbContext;

        public ProductService(TDbContext context)
        {
            dbContext = context;
        }
        public async Task CreateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }
        public async Task<List<T>> SelectAll<T>() where T : class
        {
            return await this.dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> SelectById<T>(Guid id) where T : class
        {
            return await this.dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.dbContext.ChangeTracker.Clear();
            this.dbContext.Set<T>().Update(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }
    }
}
