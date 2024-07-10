namespace Project.Factories;

using System.Collections.Generic;
using Project.Nodes;
using Project.Operators;

public abstract class ConnectStrategy<T> : IConnectStrategy<T>
    where T : IOperator
{
    public IOperationFactory OperationFactory { get; private set; }

    protected ConnectStrategy()
    {
        OperationFactory = new OperationFactory();
    }

    public abstract void Connect(T tOperator, IList<INode> operands);
}
