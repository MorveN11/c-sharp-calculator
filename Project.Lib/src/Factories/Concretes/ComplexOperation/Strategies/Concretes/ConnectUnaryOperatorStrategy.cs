namespace Project.Factories;

using Project.Nodes;
using Project.Operations;
using Project.Operators;
using Project.Utils;

public class ConnectUnaryOperatorStrategy : ConnectStrategy<IUnaryOperator>
{
    public ConnectUnaryOperatorStrategy()
        : base() { }

    public override void Connect(IUnaryOperator tOperator, IList<INode> operands)
    {
        if (tOperator == null || operands == null)
        {
            return;
        }

        int reference = tOperator.Reference;

        INode operand = Functions.GetOperation(reference, operands[reference], operands)!;

        IOperation operation = OperationFactory.Create(tOperator, operand.Operation!);

        operands[operand.Parent] = new Node(operation, operand.Parent);
    }
}
