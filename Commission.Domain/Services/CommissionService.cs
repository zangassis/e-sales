using Commission.Domain.Entities;
using Commission.Domain.Repositories;

namespace Commission.Domain.Services;

public class CommissionService
{
	private readonly ICommissionRepository _commissionRepository;

	public CommissionService(ICommissionRepository commissionRepository)
	{
		_commissionRepository = commissionRepository;
	}
	
	public async Task CalculateCommission(Guid saleId, decimal saleAmount)
	{
		if (saleAmount <= 0) throw new ArgumentException("Sale amount must be greater than zero.", nameof(saleAmount));
		
		var commission = new SaleCommission(saleId, saleAmount, DateTime.Now, "Standard");

		decimal baseRate = 0.05m; // 5%

		commission.ApplyRate(baseRate);
		
		commission.Process();
		
		await _commissionRepository.Add(commission);
	}
}
