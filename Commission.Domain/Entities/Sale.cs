namespace Commission.Domain.Entities;
public class Sale
{
    public Guid Id { get; private set; }
    public decimal TotalAmount { get; private set; }
    public DateTime Date { get; private set; }
    public Guid SalespersonId { get; private set; }

    public Sale(decimal totalAmount, DateTime date, Guid salespersonId)
    {
        Id = Guid.NewGuid();
        TotalAmount = totalAmount;
        Date = date;
        SalespersonId = salespersonId;
    }
}

