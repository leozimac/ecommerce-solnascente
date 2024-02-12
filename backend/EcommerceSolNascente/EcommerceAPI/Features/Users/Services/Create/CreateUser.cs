using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Create;
public class CreateUser : ICreateUser
{
    public Task<UserVm> CreateAsync(CreateUserVm vm) 
        => throw new NotImplementedException();
}
