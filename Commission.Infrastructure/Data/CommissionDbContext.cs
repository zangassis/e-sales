using Commission.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Commission.Infrastructure.Data;

public class CommissionDbContext : DbContext
{
    public DbSet<SaleCommission> SaleCommissions { get; set; }

    public CommissionDbContext(DbContextOptions<CommissionDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleCommission>()
            .Property(sc => sc.CurrencyCode)
            .HasColumnName("CurrencyCode")
            .HasColumnType("nvarchar(3)");

        base.OnModelCreating(modelBuilder);
    }
}