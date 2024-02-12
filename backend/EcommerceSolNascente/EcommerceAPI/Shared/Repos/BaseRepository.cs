namespace EcommerceAPI.Shared.Repos;
public class BaseRepository<T> : IBaseRepository<T>
{
    public async Task<T> CreateAsync(T entity) 
        => throw new NotImplementedException();

    public async Task<T> FindAsync(long id) 
        => throw new NotImplementedException();

    public async Task<IList<T>> ListAsync() 
        => throw new NotImplementedException();

    public async Task<T> RemoveAsync(T entity) 
        => throw new NotImplementedException();

    public async Task<T> UpdateAsync(T entity) 
        => throw new NotImplementedException();
}
