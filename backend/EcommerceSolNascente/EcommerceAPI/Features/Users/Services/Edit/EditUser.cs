using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Edit;
public class EditUser : IEditUser
{
    public Task<UserVm> EditAsync(long id, CreateUserVm vm) 
        => throw new NotImplementedException();
}
