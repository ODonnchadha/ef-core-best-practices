using GloboTicket.SharedKernel.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.Infrastructure.Configuration
{
    internal class SqlModelConfiguration : IModelConfiguration
    {
        public void ConfigureModel(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(SqlModelConfiguration).Assembly);
        }
    }
}
