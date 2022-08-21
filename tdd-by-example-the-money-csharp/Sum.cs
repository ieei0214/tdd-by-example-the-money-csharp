namespace tdd_by_example_the_money_csharp;

public class Sum : Expression
{
    public Expression augend;
    public Expression addend;

    public Sum(Money money, Money addend)
    {
        this.augend = money;
        this.addend = addend;
    }

    public Money reduce(Bank bank, string to)
    {
        int amount = augend.reduce(bank, to).Amount + addend.reduce(bank, to).Amount;
        return new Money(amount, to);
    }
}