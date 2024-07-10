namespace Project.Parsers;

using Project.Nodes;

public interface IInputOperandsParser
{
    public IList<INode> Parse(string input);
}
