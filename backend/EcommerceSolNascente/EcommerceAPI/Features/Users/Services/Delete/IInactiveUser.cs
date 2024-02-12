using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.Services.Delete;
public interface IInactiveUser
{
    Task<bool> Inactivate(long id);
}
