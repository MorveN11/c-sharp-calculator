namespace Project.Nodes;

using Project.Operations;

public interface INode
{
    IOperation? Operation { get; }
    int Parent { get; }
}
