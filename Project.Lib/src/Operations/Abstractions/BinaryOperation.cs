namespace Project.Operations;

public abstract class BinaryOperation : IOperation
{
    protected IOperation FirstValue { get; }
    protected IOperation SecondValue { get; }

    protected BinaryOperation(IOperation firstValue, IOperation secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }

    public abstract double Execute();
}
