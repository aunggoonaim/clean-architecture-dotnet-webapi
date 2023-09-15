using OfficeBoardApi.Application.Repositories;
using OfficeBoardApi.Persistence.Context;
using OfficeBoardApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeBoardApi.Domain.Setting;

namespace OfficeBoardApi.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");

        if (connectionString is null)
        {
            throw new Exception("Not found Sqlite connection string.");
        }

        services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

        services.Configure<AppSetting>(configuration.GetSection("AppSettings"));
        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddHealthChecks();
    }
}