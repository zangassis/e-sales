namespace Commission.Domain.Events;
public class SaleCompletedEvent
{
    public Guid SaleId { get; private set; }
    public decimal TotalAmount { get; private set; }
    public DateTime Date { get; private set; }

    public SaleCompletedEvent(Guid saleId, decimal totalAmount, DateTime date)
    {
        SaleId = saleId;
        TotalAmount = totalAmount;
        Date = date;
    }
}