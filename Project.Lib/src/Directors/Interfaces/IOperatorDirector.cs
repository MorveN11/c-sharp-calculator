namespace Project.Directors;

using Project.Builders;
using Project.Operators;

public interface IOperatorDirector<T, U>
    where T : class, IOperatorBuilder<U>, new()
    where U : class, IOperator, new()
{
    public T Builder { get; set; }
}
