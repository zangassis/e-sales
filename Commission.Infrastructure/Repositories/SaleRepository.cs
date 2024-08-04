using Commission.Domain.Entities;
using Commission.Domain.Repositories;
using Commission.Infrastructure.Data;

namespace Commission.Domain.Services;
public class SaleRepository : ISaleRepository
{
	private readonly CommissionDbContext _context;

	public SaleRepository(CommissionDbContext context)
	{
		_context = context;
	}

	public async Task Add(Sale sale)
	{
		await _context.Sales.AddAsync(sale);
	    await _context.SaveChangesAsync();
	}

	public async Task<Sale> GetById(Guid id)
	{
		return await _context.Sales.FindAsync(id);
	}
}
