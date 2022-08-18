namespace tdd_by_example_the_money_csharp;

public class Dollar
{
    public int amount;

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public void times(int multiplier)
    {
        amount *= multiplier;
    }
}