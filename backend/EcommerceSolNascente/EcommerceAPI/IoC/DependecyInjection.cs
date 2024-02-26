using EcommerceAPI.Features.Users.IoC;

using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.IoC;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        #region DbContext
        var dbHost = config["DB_HOST"];
        var dbPort = config["DB_PORT"];
        var dbDatabase = config["DB_DATABASE"];
        var dbUser = config["DB_USER"];
        var dbPassword = config["DB_PWD"];

        var connectionString = $"server={dbHost};port={dbPort};userid={dbUser};pwd={dbPassword};database={dbDatabase};default command timeout=0;";

        services.AddDbContext<DataContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
        #endregion

        //services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails();

        services.AddAutoMapper(typeof(Program).Assembly);

        services.AddUserInfrastructure();


        return services;
    }
}
