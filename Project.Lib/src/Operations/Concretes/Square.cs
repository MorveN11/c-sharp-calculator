namespace Project.Operations;

public class Square : UnaryOperation
{
    public Square(IOperation value)
        : base(value) { }

    public override double Execute()
    {
        return Value.Execute() * Value.Execute();
    }
}
