namespace Project.Operations;

public class SquareRoot : UnaryOperation
{
    public SquareRoot(IOperation value)
        : base(value) { }

    protected override double Execute()
    {
        return Math.Sqrt(Value.GetResult());
    }
}
