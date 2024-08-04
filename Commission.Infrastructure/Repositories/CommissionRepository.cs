using Commission.Domain.Entities;
using Commission.Domain.Repositories;
using Commission.Infrastructure.Data;
namespace Commission.Infrastructure.Repositories;

public class CommissionRepository : ICommissionRepository
{
    private readonly CommissionDbContext _context;

    public CommissionRepository(CommissionDbContext context)
    {
        _context = context;
    }

    public async Task Add(SaleCommission commission)
    {
       await _context.SaleCommissions.AddAsync(commission);
       await _context.SaveChangesAsync();
    }

    public async Task<SaleCommission> GetById(Guid id)
    {
        return await _context.SaleCommissions.FindAsync(id);
    }
}
