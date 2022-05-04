 namespace ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces
{
    public interface IProductService
    {
        Task<List<T>> SelectAll<T>() where T : class;
        Task<T> SelectById<T>(Guid id) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
