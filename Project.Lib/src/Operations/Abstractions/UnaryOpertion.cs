namespace Project.Operations;

public abstract class UnaryOperation : Operation, IUnaryOperation
{
    public IOperation Value { get; }

    protected UnaryOperation(IOperation value)
    {
        Value = value;
    }
}
