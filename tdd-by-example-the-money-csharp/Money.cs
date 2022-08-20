namespace tdd_by_example_the_money_csharp;

public abstract class Money
{
    protected int amount;

    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;

        return money.amount == amount && this.GetType().Equals(obj.GetType());
    }

    public static Money dollar(int amount)
    {
        return new Dollar(amount);
    }
    public static Money franc(int amount)
    {
        return new Franc(amount);
    }

    public abstract Money times(int multiplier);

    public abstract string currency();
}