using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Dollar : Money
{
    private readonly string _currency;

    public Dollar(int amount)
    {
        this.amount = amount;
        _currency = "USD";
    }

    public override Money times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override string currency()
    {
        return _currency;
    }
}