using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Domain.DataAccess;

namespace Native.Domain
{
    public static class Extensions
    {

        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NativeContext>(
                opts => opts.UseSqlServer(connectionString, 
                    b => b.MigrationsAssembly(GetAssemblyName())));
        }

        private static string GetAssemblyName() => typeof(Venue).Assembly.GetName().Name!;
    }
}