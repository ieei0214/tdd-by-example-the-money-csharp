namespace tdd_by_example_the_money_csharp;

public class Bank
{
    public Money reduce(Expression source, string to)
    {
        if (source.GetType() == typeof(Money))
        {
            return ((Money) source).reduce(to);
        }
        Sum sum = (Sum)source;
        return sum.reduce(to);
    }
}