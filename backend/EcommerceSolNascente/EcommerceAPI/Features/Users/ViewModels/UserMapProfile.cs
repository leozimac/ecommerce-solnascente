using AutoMapper;

using EcommerceAPI.Features.Users.Models;

namespace EcommerceAPI.Features.Users.ViewModels
{
    public class UsersMapProfile : Profile
    {
        public UsersMapProfile()
        {
            CreateMap<User, UserVm>().ReverseMap();
            CreateMap<CreateUserVm, User>();
        }
    }
}
