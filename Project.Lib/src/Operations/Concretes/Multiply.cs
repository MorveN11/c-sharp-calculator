namespace Project.Operations;

public class Multiply : BinaryOperation
{
    public Multiply(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    protected override double Execute()
    {
        return FirstValue.GetResult() * SecondValue.GetResult();
    }
}
