namespace Project.Directors;

using Project.Builders;
using Project.Models;
using Project.Operators;

public class UnaryOperatorDirector
    : OperatorDirector<UnaryOperatorBuilder, UnaryOperator>,
        IUnaryOperatorDirector
{
    public UnaryOperatorDirector()
        : base() { }

    public UnaryOperator ConstructSquareOperator(int reference = 0)
    {
        return Builder.SetReference(reference).SetProvenance(OperatorProvenance.Square).Build();
    }

    public UnaryOperator ConstructSquareRootOperator(int reference = 0)
    {
        return Builder.SetReference(reference).SetProvenance(OperatorProvenance.SquareRoot).Build();
    }
}
