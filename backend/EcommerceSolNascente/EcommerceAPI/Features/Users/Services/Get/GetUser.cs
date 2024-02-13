using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Get;
public class GetUser : IGetUser
{
    public async Task<UserVm?> FindAsync(long id) 
        => throw new NotImplementedException();

    public async Task<IList<UserVm>> ListAsync() 
        => throw new NotImplementedException();
}
