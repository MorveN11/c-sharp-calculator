namespace Project.Operations;

public class Add : BinaryOperation
{
    public Add(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    protected override double Execute()
    {
        return FirstValue.GetResult() + SecondValue.GetResult();
    }
}
