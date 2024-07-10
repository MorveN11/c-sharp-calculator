namespace Project.Directors;

using Project.Builders;
using Project.Operators;

public class OperatorDirector<TOB, TO> : IOperatorDirector<TOB, TO>
    where TOB : class, IOperatorBuilder<TO>, new()
    where TO : class, IOperator, new()
{
    public TOB Builder { get; set; }

    public OperatorDirector()
    {
        Builder = new TOB();
    }
}
