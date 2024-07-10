namespace Project.Operators;

public class BinaryOperator : MathOperator, IBinaryOperator
{
    public int FirstReference { get; set; }
    public int SecondReference { get; set; }

    public BinaryOperator()
        : base() { }

    public BinaryOperator(int firstReference, int secondReference)
        : base()
    {
        FirstReference = firstReference;
        SecondReference = secondReference;
    }

    public override bool Equals(object? obj)
    {
        if (obj is BinaryOperator other)
        {
            return base.Equals(obj)
                && FirstReference == other.FirstReference
                && SecondReference == other.SecondReference;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() ^ FirstReference ^ SecondReference;
    }

    public override string ToString()
    {
        return $"""
            {base.ToString()}
            First Reference: {FirstReference}
            Second Reference: {SecondReference}
            """;
    }
}
