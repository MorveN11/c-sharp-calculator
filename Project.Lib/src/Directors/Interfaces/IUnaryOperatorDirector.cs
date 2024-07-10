namespace Project.Directors;

using Project.Builders;
using Project.Operators;

public interface IUnaryOperatorDirector : IOperatorDirector<UnaryOperatorBuilder, UnaryOperator>
{
    UnaryOperator ConstructSquareOperator(int reference = 0);

    public UnaryOperator ConstructSquareRootOperator(int reference = 0);
}
