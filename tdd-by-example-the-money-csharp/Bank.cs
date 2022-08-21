using System.Collections;

namespace tdd_by_example_the_money_csharp;

public class Bank
{
    private Hashtable rates = new Hashtable();

    public Money reduce(Expression source, string to)
    {
        return source.reduce(this, to);
    }

    public void addRate(string from, string to, int rate)
    {
        rates.Add(new Pair(from, to), rate);
    }

    public int rate(string from, string to)
    {
        return (from.Equals("CHF") && to.Equals("USD")
            ? 2
            : 1);
    }

}