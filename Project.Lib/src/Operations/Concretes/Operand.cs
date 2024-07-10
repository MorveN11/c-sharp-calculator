namespace Project.Operations;

public class Operand : Operation
{
    public double Value { get; private set; }

    public Operand(double value)
    {
        Value = value;
    }

    protected override double Execute()
    {
        return Value;
    }
}
