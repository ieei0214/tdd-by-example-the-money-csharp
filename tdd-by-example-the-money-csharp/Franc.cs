using System.ComponentModel;

namespace tdd_by_example_the_money_csharp;

public class Franc : Money
{
    private int amount;

    public Franc(int amount)
    {
        this.amount = amount;
    }

    public Franc times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        Franc franc = (Franc) obj;
        
        return franc.amount == amount;
    }
}