namespace Project.Operations;

public class SquareRoot : UnaryOperation
{
    public SquareRoot(IOperation value)
        : base(value) { }

    public override double Execute()
    {
        return Math.Sqrt(Value.Execute());
    }
}
