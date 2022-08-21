namespace tdd_by_example_the_money_csharp;

public class Bank
{
    public Money reduce(Expression source, string to)
    {
        return source.reduce(this, to);
    }
}