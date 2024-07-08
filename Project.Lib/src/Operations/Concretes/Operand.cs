namespace Project.Operations;

public class Operand : IOperation
{
    private readonly double _value;

    public Operand(double value)
    {
        _value = value;
    }

    public double Execute()
    {
        return _value;
    }
}
