namespace Project.Factories;

using Project.Operations;

public interface IComplexOperationFactory
{
    IOperation Create(string input);
}
