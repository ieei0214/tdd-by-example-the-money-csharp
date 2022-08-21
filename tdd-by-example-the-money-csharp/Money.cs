namespace tdd_by_example_the_money_csharp;

public class Money : Expression
{
    public int Amount;
    protected string Currency;

    public Money(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;

        return money.Amount == Amount && currency().Equals(money.currency());
    }

    public static Money dollar(int amount)
    {
        return new Money(amount, "USD");
    }
    public static Money franc(int amount)
    {
        return new Money(amount, "CHF");
    }

    public virtual Money times(int multiplier)
    {
        return new Money(Amount * multiplier, Currency);
    }

    public virtual string currency()
    {
        return Currency;
    }

    public override string ToString()
    {
        return Amount + " " + Currency;
    }

    public Expression plus(Money addend)
    {
        return new Sum(this, addend);
    }

    public Money reduce(Bank bank, string to)
    {
        int rate = Currency.Equals("CHF") && to.Equals("USD")
            ? 2
            : 1;
        return new Money(Amount / rate, to);
    }
}