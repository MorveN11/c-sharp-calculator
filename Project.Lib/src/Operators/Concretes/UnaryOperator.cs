namespace Project.Operators;

public class UnaryOperator : MathOperator, IUnaryOperator
{
    public int Reference { get; set; }

    public UnaryOperator()
        : base() { }

    public UnaryOperator(int reference)
        : base()
    {
        Reference = reference;
    }

    public override bool Equals(object? obj)
    {
        if (obj is UnaryOperator other)
        {
            return base.Equals(obj) && Reference == other.Reference;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() ^ Reference.GetHashCode();
    }

    public override string ToString()
    {
        return $"""
            {base.ToString()}
            Reference: {Reference}
            """;
    }
}
