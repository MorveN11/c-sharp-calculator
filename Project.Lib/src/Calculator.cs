namespace Project;

using Project.Factories;
using Project.Operations;

public class Calculator
{
    private readonly IComplexOperationFactory _complexOperationFactory;

    public Calculator(IComplexOperationFactory complexOperationFactory)
    {
        _complexOperationFactory = complexOperationFactory;
    }

    public double Calculate(string expression)
    {
        IOperation operation = _complexOperationFactory.Create(expression);

        return operation.GetResult();
    }
}
