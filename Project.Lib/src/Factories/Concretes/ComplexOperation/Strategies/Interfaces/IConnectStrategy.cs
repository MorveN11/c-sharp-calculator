namespace Project.Factories;

using Project.Nodes;
using Project.Operators;

public interface IConnectStrategy<T>
    where T : IOperator
{
    void Connect(T tOperator, IList<INode> operands);
}
