namespace Commission.Domain.ValueObjects;
public class CommissionRate
{
    public decimal Rate { get; private set; }

    public CommissionRate(decimal rate)
    {
        if (rate <= 0 || rate > 1)
            throw new ArgumentException("Rate must be between 0 and 1.");
        Rate = rate;
    }
}
