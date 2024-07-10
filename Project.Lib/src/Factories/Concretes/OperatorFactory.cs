namespace Project.Factories;

using Project.Directors;
using Project.Operators;

public class OperatorFactory : IOperatorFactory
{
    private readonly IBinaryOperatorDirector _binaryOperatorDirector;
    private readonly IUnaryOperatorDirector _unaryOperatorDirector;

    public OperatorFactory(
        IBinaryOperatorDirector binaryOperatorDirector,
        IUnaryOperatorDirector unaryOperatorDirector
    )
    {
        _binaryOperatorDirector = binaryOperatorDirector;
        _unaryOperatorDirector = unaryOperatorDirector;
    }

    public IOperator Create(string type)
    {
        return type switch
        {
            "+" => _binaryOperatorDirector.ConstructAddOperator(),
            "-" => _binaryOperatorDirector.ConstructSubtractOperator(),
            "*" => _binaryOperatorDirector.ConstructMultiplyOperator(),
            "/" => _binaryOperatorDirector.ConstructDivideOperator(),
            "~" => _unaryOperatorDirector.ConstructSquareOperator(),
            "^" => _unaryOperatorDirector.ConstructSquareRootOperator(),
            _ => throw new InvalidOperationException("Invalid operation type."),
        };
    }
}
