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

	public void Add(Sale sale)
	{
		_context.Sales.Add(sale);
		_context.SaveChanges();
	}

	public Sale GetById(Guid id)
	{
		return _context.Sales.Find(id);
	}
}
