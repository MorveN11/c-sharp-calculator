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
    private readonly OperationFactory _operationFactory;

    public ComplexOperationFactory(
        IInputOperandsParser inputOperandsParser,
        IInputOperatorsParser inputOperatorsParser
    )
    {
        _inputOperandsParser = inputOperandsParser;
        _inputOperatorsParser = inputOperatorsParser;
        _operationFactory = new OperationFactory();
    }

    private static INode GetOperation(int index, INode node, IList<INode> operands)
    {
        if (index == node.Parent)
        {
            return node;
        }

        return GetOperation(node.Parent, operands[node.Parent], operands);
    }

    private IOperation ConstructOperation(IList<INode> operands, IList<IOperator> operators)
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
                    INode operand = GetOperation(
                        unaryOperator.Reference,
                        operands[unaryOperator.Reference],
                        operands
                    );

                    IOperation operation = _operationFactory.Create(
                        unaryOperator,
                        operand.Operation
                    );

                    operands[operand.Parent] = new Node(operation, operand.Parent);
                }
                else if (mathOperator is IBinaryOperator binaryOperator)
                {
                    INode leftOperand = GetOperation(
                        binaryOperator.FirstReference,
                        operands[binaryOperator.FirstReference],
                        operands
                    );

                    INode rightOperand = GetOperation(
                        binaryOperator.SecondReference,
                        operands[binaryOperator.SecondReference],
                        operands
                    );

                    IOperation operation = _operationFactory.Create(
                        binaryOperator,
                        leftOperand.Operation,
                        rightOperand.Operation
                    );

                    operands[leftOperand.Parent] = new Node(operation, leftOperand.Parent);
                    operands[rightOperand.Parent] = new Node(new Operand(0), leftOperand.Parent);
                }
            }
        }

        return operands[0].Operation;
    }

    public IOperation Create(string input)
    {
        IList<INode> operands = _inputOperandsParser.Parse(input);
        IList<IOperator> operators = _inputOperatorsParser.Parse(input);

        IOperation operation = ConstructOperation(operands, operators);

        return operation;
    }
}
