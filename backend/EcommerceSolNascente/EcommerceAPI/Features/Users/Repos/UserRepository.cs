using EcommerceAPI.Features.Users.Models;
using EcommerceAPI.Shared.Repos;

namespace EcommerceAPI.Features.Users.Repos;
public class UserRepository : BaseRepository<User>, IUserRepository
{
}
