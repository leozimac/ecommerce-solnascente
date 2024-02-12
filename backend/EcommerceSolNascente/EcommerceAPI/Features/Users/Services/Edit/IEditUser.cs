using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Edit;
public interface IEditUser
{
    Task<UserVm> EditAsync(long id, CreateUserVm vm);
}
