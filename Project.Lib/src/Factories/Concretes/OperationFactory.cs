namespace Project.Factories;

using Project.Models;
using Project.Operations;
using Project.Operators;

public class OperationFactory : IOperationFactory
{
    public OperationFactory() { }

    public IBinaryOperation Create(
        IBinaryOperator operationType,
        IOperation firstValue,
        IOperation secondValue
    )
    {
        return operationType?.Provenance switch
        {
            OperatorProvenance.Subtract => new Subtract(firstValue, secondValue),
            OperatorProvenance.Add => new Add(firstValue, secondValue),
            OperatorProvenance.Divide => new Divide(firstValue, secondValue),
            OperatorProvenance.Multiply => new Multiply(firstValue, secondValue),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }

    public IUnaryOperation Create(IUnaryOperator operationType, IOperation value)
    {
        return operationType?.Provenance switch
        {
            OperatorProvenance.Square => new Square(value),
            OperatorProvenance.SquareRoot => new SquareRoot(value),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }
}
