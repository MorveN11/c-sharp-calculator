namespace Project.Operations;

public class Divide : BinaryOperation
{
    public Divide(IOperation firstValue, IOperation secondValue)
        : base(firstValue, secondValue) { }

    public override double Execute()
    {
        return FirstValue.Execute() / SecondValue.Execute();
    }
}
