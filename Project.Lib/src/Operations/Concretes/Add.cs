namespace Project.Operations;

public class Add : BinaryOperation
{
    public Add(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    public override double Execute()
    {
        return FirstValue.Execute() + SecondValue.Execute();
    }
}
