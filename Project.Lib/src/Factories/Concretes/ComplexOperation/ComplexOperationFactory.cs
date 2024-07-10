namespace Project.Factories;

using Project.Nodes;
using Project.Operations;
using Project.Operators;
using Project.Parsers;
using Project.Utils;

public class ComplexOperationFactory : IComplexOperationFactory
{
    private readonly IInputOperandsParser _inputOperandsParser;
    private readonly IInputOperatorsParser _inputOperatorsParser;

    public ComplexOperationFactory(
        IInputOperandsParser inputOperandsParser,
        IInputOperatorsParser inputOperatorsParser
    )
    {
        _inputOperandsParser = inputOperandsParser;
        _inputOperatorsParser = inputOperatorsParser;
    }

    private static IOperation ConstructOperation(IList<INode> operands, IList<IOperator> operators)
    {
        for (uint i = ProjectConstants.MaxProvenance; i > 0; i--)
        {
            for (int j = 0; j < operators.Count; j++)
            {
                IOperator mathOperator = operators[j];

                if (i != (int)mathOperator.Provenance)
                {
                    continue;
                }

                if (mathOperator is IUnaryOperator unaryOperator)
                {
                    ConnectStrategy<IUnaryOperator> connectStrategy =
                        new ConnectUnaryOperatorStrategy();

                    connectStrategy.Connect(unaryOperator, operands);
                }
                else if (mathOperator is IBinaryOperator binaryOperator)
                {
                    ConnectStrategy<IBinaryOperator> connectStrategy =
                        new ConnectBinaryOperatorStrategy();

                    connectStrategy.Connect(binaryOperator, operands);
                }
            }
        }

        return operands[0].Operation!;
    }

    public IOperation Create(string input)
    {
        IList<INode> operands = _inputOperandsParser.Parse(input);
        IList<IOperator> operators = _inputOperatorsParser.Parse(input);

        IOperation operation = ConstructOperation(operands, operators);

        return operation;
    }
}
