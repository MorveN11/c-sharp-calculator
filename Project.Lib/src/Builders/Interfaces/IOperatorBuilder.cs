namespace Project.Builders;

using Project.Models;
using Project.Operators;

public interface IOperatorBuilder<T>
    where T : class, IOperator, new()
{
    void Reset();

    IOperatorBuilder<T> SetProvenance(OperatorProvenance provenance);

    T Build();
}
