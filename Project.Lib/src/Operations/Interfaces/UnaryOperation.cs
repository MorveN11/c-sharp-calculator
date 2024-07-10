namespace Project.Operations;

public interface IUnaryOperation : IOperation
{
    protected IOperation Value { get; }
}
