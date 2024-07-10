namespace Project.Parsers;

using Project.Operators;

public interface IInputOperatorsParser
{
    public IList<IOperator> Parse(string input);
}
