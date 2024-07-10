namespace Project.Operations;

public class Divide : BinaryOperation
{
    public Divide(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    protected override double Execute()
    {
        return FirstValue.GetResult() / SecondValue.GetResult();
    }
}
