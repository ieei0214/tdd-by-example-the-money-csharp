namespace tdd_by_example_the_money_csharp;

public abstract class Money
{
    protected int Amount;
    protected string Currency;

    protected Money(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;

        return money.Amount == Amount && this.GetType().Equals(obj.GetType());
    }

    public static Money dollar(int amount)
    {
        return new Dollar(amount, "USD");
    }
    public static Money franc(int amount)
    {
        return new Franc(amount, "CHF");
    }

    public abstract Money times(int multiplier);

    public virtual string currency()
    {
        return Currency;
    }
}