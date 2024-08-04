using Commission.Domain.Entities;

namespace Commission.Domain.Repositories;

public interface ISaleRepository
{
    Task Add(Sale sale);
    Task<Sale> GetById(Guid id);
}
