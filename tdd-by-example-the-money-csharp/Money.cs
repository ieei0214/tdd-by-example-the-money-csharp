namespace tdd_by_example_the_money_csharp;

public class Money
{
    protected int amount;

    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;

        return money.amount == amount;
    }
}