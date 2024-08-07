using Commission.Domain.ValueObjects;

namespace Commission.Domain.Services
{
    public interface ICommissionService
    {
        Task ProcessCommission(Guid saleId, Currency currency, decimal saleAmount);
    }
}