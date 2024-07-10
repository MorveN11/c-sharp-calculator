namespace Project.Operations;

public class Square : UnaryOperation
{
    public Square(IOperation value)
        : base(value) { }

    protected override double Execute()
    {
        return Value.GetResult() * Value.GetResult();
    }
}
