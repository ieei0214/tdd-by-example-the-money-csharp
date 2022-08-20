using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    public Franc(int amount, string currency) : base(amount, currency)
    {
    }
    public override Money times(int multiplier)
    {
        return Money.franc(Amount * multiplier, Currency);
    }
}