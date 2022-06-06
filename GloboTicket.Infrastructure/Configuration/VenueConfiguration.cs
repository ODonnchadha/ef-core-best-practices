using GloboTicket.Domain;
using GloboTicket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GloboTicket.Infrastructure.Configuration
{
    /// <summary>
    /// Specific DB Configuration. e.g.: SQL Server.
    /// </summary>
    internal class VenueConfiguration
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.ToTable("VenueTable");
        }
    }
}
