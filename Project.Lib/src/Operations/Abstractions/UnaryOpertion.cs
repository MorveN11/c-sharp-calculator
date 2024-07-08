namespace Project.Operations;

public abstract class UnaryOperation : IOperation
{
    protected IOperation Value { get; }

    protected UnaryOperation(IOperation value)
    {
        Value = value;
    }

    public abstract double Execute();
}
