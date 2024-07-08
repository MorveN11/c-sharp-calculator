namespace Project.Factories;

using Project.Models;
using Project.Operations;

public class OperationFactory : IOperationFactory
{
    public OperationFactory() { }

    public BinaryOperation Create(
        BinaryOperationType operationType,
        IOperation firstValue,
        IOperation secondValue
    )
    {
        return operationType switch
        {
            BinaryOperationType.Add => new Add(firstValue, secondValue),
            BinaryOperationType.Subtract => new Subtract(firstValue, secondValue),
            BinaryOperationType.Multiply => new Multiply(firstValue, secondValue),
            BinaryOperationType.Divide => new Divide(firstValue, secondValue),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }

    public UnaryOperation Create(UnaryOperationType operationType, IOperation value)
    {
        return operationType switch
        {
            UnaryOperationType.Square => new Square(value),
            UnaryOperationType.SquareRoot => new SquareRoot(value),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }
}
