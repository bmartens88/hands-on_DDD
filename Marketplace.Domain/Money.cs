using Marketplace.Framework;

namespace Marketplace.Domain;

public class Money : ValueObject
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
    }

    public Money Add(Money summand)
    {
        return new Money(Amount + summand.Amount);
    }

    public Money Subtract(Money subtrahend)
    {
        return new Money(Amount - subtrahend.Amount);
    }

    public static Money operator +(Money summand1, Money summand2)
    {
        return summand1.Add(summand2);
    }

    public static Money operator -(Money minuend, Money subtrahend)
    {
        return minuend.Subtract(subtrahend);
    }
}