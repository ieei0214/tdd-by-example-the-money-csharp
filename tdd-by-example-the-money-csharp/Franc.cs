using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    private readonly string _currency;

    public Franc(int amount)
    {
        this.amount = amount;
        _currency = "CHF";
    }

    public override Money times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override string currency()
    {
        return _currency;
    }
}