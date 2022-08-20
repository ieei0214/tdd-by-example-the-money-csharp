using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    public Franc(int amount)
    {
        this.amount = amount;
    }

    public override Money times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override string currency()
    {
        return "CHF";
    }
}