using Data.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class DataExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
            throw new ArgumentException("Connectionstring missing, paste in user secret");

            services.AddDbContext<UserDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            return services;
        }

    }
}
