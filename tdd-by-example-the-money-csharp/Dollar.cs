using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Dollar : Money
{
    public Dollar(int amount, string currency)
    {
        this.amount = amount;
        _currency = currency;
    }

    public override Money times(int multiplier)
    {
        return Money.dollar(amount * multiplier);
    }
}