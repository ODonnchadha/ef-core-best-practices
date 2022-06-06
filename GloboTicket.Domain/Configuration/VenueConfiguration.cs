using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GloboTicket.Domain.Configuration;

/// <summary>
/// Fluent configuration(s).
/// </summary>
public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder
            .Property(v => v.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(v => v.Address)
            .HasMaxLength(300);
    }
}
