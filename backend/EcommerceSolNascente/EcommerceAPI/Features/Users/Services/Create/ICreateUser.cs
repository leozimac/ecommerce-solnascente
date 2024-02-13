using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Create;
public interface ICreateUser
{
    Task<UserVm> CreateAsync(CreateUserVm vm);
}
