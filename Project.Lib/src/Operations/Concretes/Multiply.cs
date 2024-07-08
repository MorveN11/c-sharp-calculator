namespace Project.Operations;

public class Multiply : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;

    public Multiply(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }

    public double Execute()
    {
        return _left.Execute() * _right.Execute();
    }
}
