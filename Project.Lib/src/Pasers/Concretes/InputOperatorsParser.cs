namespace Project.Parsers;

using System.Text.RegularExpressions;
using Project.Factories;
using Project.Operators;
using Project.Utils;

public class InputOperatorsParser : IInputOperatorsParser
{
    private readonly IOperatorFactory _factory;

    public InputOperatorsParser(IOperatorFactory factory)
    {
        _factory = factory;
    }

    public IList<IOperator> Parse(string input)
    {
        IList<IOperator> operators = [];

        MatchCollection matches = ProjectConstants.Operator().Matches(input);

        int count = 0;
        foreach (Match match in matches)
        {
            IOperator operatorType = _factory.Create(match.Value);

            if (operatorType is UnaryOperator unaryOperator)
            {
                unaryOperator.Reference = count;
                operators.Add(unaryOperator);
            }

            if (operatorType is BinaryOperator binaryOperator)
            {
                binaryOperator.FirstReference = count;
                binaryOperator.SecondReference = ++count;
                operators.Add(binaryOperator);
            }
        }

        return operators;
    }
}
