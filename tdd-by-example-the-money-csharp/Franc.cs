using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    public Franc(int amount)
    {
        this.amount = amount;
    }

    public Franc times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }
}