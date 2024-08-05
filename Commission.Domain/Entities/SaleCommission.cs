using Commission.Domain.ValueObjects;

namespace Commission.Domain.Entities;

public class SaleCommission
{
    public Guid Id { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime Date { get; private set; }
    public Guid SaleId { get; private set; }
    public string CurrencyCode { get; private set; }
    public string CommissionType { get; private set; }
    public bool IsProcessed { get; private set; }

    public Currency Currency => new Currency(CurrencyCode);

    private SaleCommission() { }

    public SaleCommission(Guid saleId, decimal amount, DateTime date, Currency currency, string commissionType)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be greater than zero.");
        if (string.IsNullOrEmpty(commissionType)) throw new ArgumentException("CommissionType cannot be null or empty.");

        Id = Guid.NewGuid();
        SaleId = saleId;
        Amount = amount;
        Date = date;
        CurrencyCode = currency.Code;
        CommissionType = commissionType;
        IsProcessed = false;
    }

    public void Process()
    {
        if (IsProcessed) throw new InvalidOperationException("Commission has already been processed.");
        IsProcessed = true;
    }

    public void ApplyRate(decimal rate)
    {
        if (rate <= 0) throw new ArgumentException("Rate must be greater than zero.");
        Amount = Amount * rate;
    }
}
