using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    public Franc(int amount, string currency)
    {
        this.amount = amount;
        _currency = "CHF";
    }

    public override Money times(int multiplier)
    {
        return Money.franc(amount * multiplier);
    }
}