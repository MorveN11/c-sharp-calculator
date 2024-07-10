namespace Project.Operations;

public class Subtract : BinaryOperation
{
    public Subtract(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    protected override double Execute()
    {
        return FirstValue.GetResult() - SecondValue.GetResult();
    }
}
