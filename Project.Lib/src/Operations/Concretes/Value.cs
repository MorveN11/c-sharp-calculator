namespace Project.Operations;

public class Value : IOperation
{
    private readonly double _value;

    public Value(double value)
    {
        _value = value;
    }

    public double Execute()
    {
        return _value;
    }
}
