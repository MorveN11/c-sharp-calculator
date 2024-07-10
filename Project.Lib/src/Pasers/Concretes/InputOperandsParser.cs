namespace Project.Parsers;

using System.Globalization;
using System.Text.RegularExpressions;
using Project.Nodes;
using Project.Operations;
using Project.Utils;

public class InputOperandsParser : IInputOperandsParser
{
    public InputOperandsParser() { }

    public IList<INode> Parse(string input)
    {
        IList<INode> operands = [];

        MatchCollection matches = ProjectConstants.Operand().Matches(input);

        int count = 0;
        foreach (Match match in matches)
        {
            INode node = new Node(
                new Operand(double.Parse(match.Value, CultureInfo.InvariantCulture)),
                count++
            );
            operands.Add(node);
        }

        return operands;
    }
}
