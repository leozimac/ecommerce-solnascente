
namespace EcommerceAPI.Features.Users.Services.Delete;
public class InactiveUser : IInactiveUser
{
    public Task<bool> Inactivate(long id) 
        => throw new NotImplementedException();
}
