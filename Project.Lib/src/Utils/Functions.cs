namespace Project.Utils;

using Project.Nodes;

public static class Functions
{
    public static INode? GetOperation(int index, INode node, IList<INode> operands)
    {
        if (node == null || operands == null)
        {
            return null;
        }

        if (index == node.Parent)
        {
            return node;
        }

        return GetOperation(node.Parent, operands[node.Parent], operands);
    }
}
