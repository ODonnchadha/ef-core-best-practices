using Microsoft.EntityFrameworkCore;

namespace GloboTicket.Domain;
public class GloboTicketContext : DbContext
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public GloboTicketContext(DbContextOptions<GloboTicketContext> options) :
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        base(options)
    {
    }

    /// <summary>
    /// NOTE: The convention of singular table names. Why?
    /// (1) 1:1 Code versus database.
    /// (2) Define entity without explicit override for table name.
    /// </summary>
    public DbSet<Venue> Venue { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // IEntityTypeConfiguration definition:
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(GloboTicketContext).Assembly);
    }
}
