namespace Project.Builders;

using Project.Models;
using Project.Operators;

public abstract class OperatorBuilder<T> : IOperatorBuilder<T>
    where T : class, IOperator, new()
{
    protected T? Operator { get; private set; }

    protected OperatorBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Operator = new T();
    }

    public IOperatorBuilder<T> SetProvenance(OperatorProvenance provenance)
    {
        Operator!.Provenance = provenance;
        return this;
    }

    public T Build()
    {
        T result = Operator!;
        Reset();
        return result;
    }
}
