using Project.Models;

namespace Project.Operators;

public abstract class Operator : IOperator
{
    public OperatorProvenance Provenance { get; set; }

    protected Operator() { }

    public override bool Equals(object? obj)
    {
        if (obj is Operator other)
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
