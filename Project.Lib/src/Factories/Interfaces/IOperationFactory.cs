namespace Project.Factories;

using Project.Models;
using Project.Operations;

public interface IOperationFactory
{
    public BinaryOperation Create(
        BinaryOperationType operationType,
        IOperation firstValue,
        IOperation secondValue
    );

    public UnaryOperation Create(UnaryOperationType operationType, IOperation value);
}
