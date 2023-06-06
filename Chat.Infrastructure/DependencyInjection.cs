using Chat.Application.Abstraction;
using Chat.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<IApplicationDbcontext, ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DbConnection"));
            });
            return service;
        }

    }
}
