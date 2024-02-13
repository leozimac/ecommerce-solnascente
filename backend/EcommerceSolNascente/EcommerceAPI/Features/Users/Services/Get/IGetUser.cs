using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Get;
public interface IGetUser
{
    Task<IList<UserVm>> ListAsync();
    Task<UserVm?> FindAsync(long id);
}
