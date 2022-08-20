namespace tdd_by_example_the_money_csharp;

public class Money
{
    protected int Amount;
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
        return new Dollar(amount, "USD");
    }
    public static Money franc(int amount)
    {
        return new Franc(amount, "CHF");
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
}