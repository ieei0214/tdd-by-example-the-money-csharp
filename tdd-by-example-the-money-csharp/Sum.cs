namespace tdd_by_example_the_money_csharp;

public class Sum : Expression
{
    public Money augend;
    public Money addend;

    public Sum(Money money, Money addend)
    {
        this.augend = money;
        this.addend = addend;
    }
}