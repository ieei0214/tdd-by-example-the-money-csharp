namespace tdd_by_example_the_money_csharp;

public class Pair
{
    private string from;
    private string to;

    public Pair(string from, string to)
    {
        this.from = from;
        this.to = to;
    }

    public override bool Equals(object? obj)
    {
        Pair pair = obj as Pair;
        return from.Equals(pair.from) && to.Equals(pair.to);
    }

    public override int GetHashCode()
    {
        return 0;
    }
}