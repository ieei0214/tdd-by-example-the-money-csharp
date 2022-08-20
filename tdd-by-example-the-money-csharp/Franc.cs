using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    public Franc(int amount, string currency) : base(amount, currency)
    {
    }
    public override Money times(int multiplier)
    {
        return new Money(Amount * multiplier, Currency);
    }
}