namespace tdd_by_example_the_money_csharp;

public class Bank
{
    public Money reduce(Expression source, string to)
    {
        return source.reduce(this, to);
    }

    public void addRate(string source, string to, int rate)
    {

    }

    public int rate(string from, string to)
    {
        return (from.Equals("CHF") && to.Equals("USD")
            ? 2
            : 1);
    }

    class Pair
    {
        private string from;
        private string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }
    }
}