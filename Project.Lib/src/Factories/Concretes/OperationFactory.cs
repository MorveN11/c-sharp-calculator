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
        return operationType.Provenance switch
        {
            1 => new Add(firstValue, secondValue),
            2 => new Subtract(firstValue, secondValue),
            3 => new Multiply(firstValue, secondValue),
            4 => new Divide(firstValue, secondValue),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }

    public UnaryOperation Create(UnaryOperationType operationType, IOperation value)
    {
        return operationType.Provenance switch
        {
            5 => new Square(value),
            6 => new SquareRoot(value),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }
}
