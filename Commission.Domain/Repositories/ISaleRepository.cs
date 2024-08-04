using Commission.Domain.Entities;

namespace Commission.Domain.Repositories;

public interface ISaleRepository
{
    void Add(Sale sale);
    Sale GetById(Guid id);
}
