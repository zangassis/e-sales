using Commission.Domain.Entities;
namespace Commission.Domain.Repositories;
public interface ICommissionRepository
{
  Task Add(SaleCommission commission);
  Task<SaleCommission> GetById(Guid id);
}
