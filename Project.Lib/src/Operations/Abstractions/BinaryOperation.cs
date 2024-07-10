namespace Project.Operations;

public abstract class BinaryOperation : Operation, IBinaryOperation
{
    public IOperation FirstValue { get; }
    public IOperation SecondValue { get; }

    protected BinaryOperation(IOperation firstValue, IOperation secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }
}
