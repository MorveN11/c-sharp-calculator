namespace Project.Operations;

public class Add : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;

    public Add(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }

    public double Execute()
    {
        return _left.Execute() + _right.Execute();
    }
}
