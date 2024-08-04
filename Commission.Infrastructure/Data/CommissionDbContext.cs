using Commission.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Commission.Infrastructure.Data;

public class CommissionDbContext : DbContext
{
    public DbSet<SaleCommission> SaleCommissions { get; set; }
    public DbSet<Sale> Sales { get; set; }

    public CommissionDbContext(DbContextOptions<CommissionDbContext> options) : base(options)
    {
    }
}

