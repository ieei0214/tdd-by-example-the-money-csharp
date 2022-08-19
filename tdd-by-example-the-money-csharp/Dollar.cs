using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Dollar
{
    private int amount;

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Dollar times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        Dollar dollar = (Dollar) obj;

        return dollar.amount == amount;
    }
}