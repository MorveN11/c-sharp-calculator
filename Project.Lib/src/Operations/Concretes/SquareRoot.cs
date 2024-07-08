namespace Project.Operations;

public class SquareRoot : IOperation
{
    private readonly IOperation _operation;

    public SquareRoot(IOperation operation)
    {
        _operation = operation;
    }

    public double Execute()
    {
        return Math.Sqrt(_operation.Execute());
    }
}
