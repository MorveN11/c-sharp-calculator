namespace Project.Factories;

using Project.Operators;

public interface IOperatorFactory
{
    IOperator Create(string type);
}
