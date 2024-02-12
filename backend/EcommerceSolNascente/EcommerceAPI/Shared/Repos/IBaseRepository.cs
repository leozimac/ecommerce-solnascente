namespace EcommerceAPI.Shared.Repos;
public interface IBaseRepository<T>
{
    Task<IList<T>> ListAsync();
    Task<T> FindAsync(long id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> RemoveAsync(T entity);
}
