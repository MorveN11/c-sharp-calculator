namespace Project.Operators;

using Project.Models;

public abstract class MathOperator : IOperator
{
    public OperatorProvenance Provenance { get; set; }

    protected MathOperator() { }

    public override bool Equals(object? obj)
    {
        if (obj is MathOperator other)
        {
            return Provenance == other.Provenance;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Provenance.GetHashCode();
    }

    public override string ToString()
    {
        return $"Provenance: {Provenance}";
    }
}
