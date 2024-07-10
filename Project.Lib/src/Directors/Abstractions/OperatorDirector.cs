namespace Project.Directors;

using Project.Builders;
using Project.Operators;

public class OperatorDirector<T, U> : IOperatorDirector<T, U>
    where T : class, IOperatorBuilder<U>, new()
    where U : class, IOperator, new()
{
    public T Builder { get; set; }

    public OperatorDirector()
    {
        Builder = new T();
    }
}
