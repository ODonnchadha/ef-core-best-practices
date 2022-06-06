using GloboTicket.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GloboTicket.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GloboTicketContext>(options =>
            {
                // GloboTicketContext configuration seperate from application domain.
                options.UseSqlServer(connectionString, sqlOptions =>
                {
                    // Keep migrations seperate from the model.
                    sqlOptions.MigrationsAssembly(
                        typeof(ServiceRegistration).Assembly.FullName);
                });
            });

            return services;
        }
    }
}