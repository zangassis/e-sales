using Commission.Domain.ValueObjects;

namespace Commission.API.Models;
public class ProcessCommissionRequest
{
    public Guid SaleId { get; set; }
    public decimal SaleAmount { get; set; }
    public Currency Currency { get; set; }
}