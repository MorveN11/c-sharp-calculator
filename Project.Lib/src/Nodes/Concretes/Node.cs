namespace Project.Nodes;

using Project.Operations;

public class Node : INode
{
    public IOperation? Operation { get; private set; }
    public int Parent { get; private set; }

    public Node(IOperation? operation, int parent)
    {
        Operation = operation;
        Parent = parent;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Node))
            return false;

        Node node = (Node)obj;

        return Operation?.Equals(node.Operation) ?? false && Parent == node.Parent;
    }

    public override int GetHashCode()
    {
        return (Operation != null ? Operation.GetHashCode() : 0) ^ Parent.GetHashCode();
    }
}
