namespace Project.Operations;

public class Subtract : BinaryOperation
{
    public Subtract(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    public override double Execute()
    {
        return FirstValue.Execute() - SecondValue.Execute();
    }
}
