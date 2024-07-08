namespace Project.Models;

public static class Constants
{
    public const int MAX_PROVENANCE = 6;
}

public abstract class OperationType
{
    public int Provenance { get; private set; }

    protected OperationType(int provenance) => Provenance = provenance;
}

public class UnaryOperationType : OperationType
{
    public int Reference { get; private set; }

    private UnaryOperationType(int provenance, int reference)
        : base(provenance)
    {
        Reference = reference;
    }

    public static UnaryOperationType Square(int reference = 0) => new(5, reference);

    public static UnaryOperationType SquareRoot(int reference = 0) => new(6, reference);
}

public class BinaryOperationType : OperationType
{
    public int FirstReference { get; private set; }
    public int SecondReference { get; private set; }

    private BinaryOperationType(int provenance, int firstReference, int secondReference)
        : base(provenance)
    {
        FirstReference = firstReference;
        SecondReference = secondReference;
    }

    public static BinaryOperationType Add(int firstReference = 0, int secondReference = 0) =>
        new(1, firstReference, secondReference);

    public static BinaryOperationType Subtract(int firstReference = 0, int secondReference = 0) =>
        new(2, firstReference, secondReference);

    public static BinaryOperationType Multiply(int firstReference = 0, int secondReference = 0) =>
        new(3, firstReference, secondReference);

    public static BinaryOperationType Divide(int firstReference = 0, int secondReference = 0) =>
        new(4, firstReference, secondReference);
}
