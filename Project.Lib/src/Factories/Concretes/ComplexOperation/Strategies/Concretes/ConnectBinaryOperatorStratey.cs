namespace Project.Factories;

using Project.Nodes;
using Project.Operations;
using Project.Operators;
using Project.Utils;

public class ConnectBinaryOperatorStrategy : ConnectStrategy<IBinaryOperator>
{
    public ConnectBinaryOperatorStrategy()
        : base() { }

    public override void Connect(IBinaryOperator tOperator, IList<INode> operands)
    {
        if (tOperator == null || operands == null)
        {
            return;
        }

        int firstReference = tOperator.FirstReference;
        int secondReference = tOperator.SecondReference;

        INode leftOperand = Functions.GetOperation(
            firstReference,
            operands[firstReference],
            operands
        )!;

        INode rightOperand = Functions.GetOperation(
            secondReference,
            operands[secondReference],
            operands
        )!;

        IOperation operation = OperationFactory.Create(
            tOperator,
            leftOperand.Operation!,
            rightOperand.Operation!
        );

        operands[leftOperand.Parent] = new Node(operation, leftOperand.Parent);
        operands[rightOperand.Parent] = new Node(null, leftOperand.Parent);
    }
}
