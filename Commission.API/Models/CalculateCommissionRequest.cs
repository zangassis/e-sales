namespace Commission.API.Models;
public class CalculateCommissionRequest
{
    public Guid SaleId { get; set; }
    public decimal SaleAmount { get; set; }
}