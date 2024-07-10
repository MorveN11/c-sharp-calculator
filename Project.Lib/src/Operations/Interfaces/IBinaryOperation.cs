namespace Project.Operations;

public interface IBinaryOperation : IOperation
{
    protected IOperation FirstValue { get; }
    protected IOperation SecondValue { get; }
}
