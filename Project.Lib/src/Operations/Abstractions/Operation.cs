namespace Project.Operations;

public abstract class Operation : IOperation
{
    private double? _result;

    protected Operation() { }

    protected abstract double Execute();

    public double GetResult()
    {
        if (!_result.HasValue)
            _result = Execute();

        return _result.Value;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Operation)
            return false;

        Operation operation = (Operation)obj;

        return GetResult().Equals(operation.GetResult());
    }

    public override int GetHashCode()
    {
        return GetResult().GetHashCode();
    }
}
