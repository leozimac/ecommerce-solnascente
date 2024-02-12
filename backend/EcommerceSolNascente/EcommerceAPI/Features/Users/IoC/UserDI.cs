using EcommerceAPI.Features.Users.Repos;
using EcommerceAPI.Features.Users.Services.Create;
using EcommerceAPI.Features.Users.Services.Delete;
using EcommerceAPI.Features.Users.Services.Edit;
using EcommerceAPI.Features.Users.Services.Get;
using EcommerceAPI.Features.Users.ViewModels;

namespace EcommerceAPI.Features.Users.IoC;

public static class UserDI
{
    public static IServiceCollection AddUserInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IGetUser, GetUser>();
        services.AddScoped<ICreateUser, CreateUser>();
        services.AddScoped<IEditUser, EditUser>();
        services.AddScoped<IInactiveUser, InactiveUser>();

        services.AddAutoMapper(config => config.AddProfile<UsersMapProfile>());

        return services;
    }
}
