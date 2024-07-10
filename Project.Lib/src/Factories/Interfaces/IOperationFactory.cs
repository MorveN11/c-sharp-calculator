namespace Project.Factories;

using Project.Operations;
using Project.Operators;

public interface IOperationFactory
{
    public IBinaryOperation Create(
        IBinaryOperator operationType,
        IOperation firstValue,
        IOperation secondValue
    );

    public IUnaryOperation Create(IUnaryOperator operationType, IOperation value);
}
