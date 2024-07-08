namespace Project.Operations;

public class Subtract : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;

    public Subtract(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }

    public double Execute()
    {
        return _left.Execute() - _right.Execute();
    }
}
