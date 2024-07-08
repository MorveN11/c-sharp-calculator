namespace Project.Operations;

public class Divide : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;

    public Divide(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }

    public double Execute()
    {
        return _left.Execute() / _right.Execute();
    }
}
