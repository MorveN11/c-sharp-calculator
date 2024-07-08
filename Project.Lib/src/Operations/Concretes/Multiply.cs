namespace Project.Operations;

public class Multiply : BinaryOperation
{
    public Multiply(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    public override double Execute()
    {
        return FirstValue.Execute() * SecondValue.Execute();
    }
}
