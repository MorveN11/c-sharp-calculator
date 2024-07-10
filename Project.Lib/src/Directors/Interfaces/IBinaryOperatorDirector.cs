namespace Project.Directors;

using Project.Builders;
using Project.Operators;

public interface IBinaryOperatorDirector : IOperatorDirector<BinaryOperatorBuilder, BinaryOperator>
{
    BinaryOperator ConstructSubtractOperator(int firstReference = 0, int secondReference = 0);

    BinaryOperator ConstructAddOperator(int firstReference = 0, int secondReference = 0);

    BinaryOperator ConstructDivideOperator(int firstReference = 0, int secondReference = 0);

    BinaryOperator ConstructMultiplyOperator(int firstReference = 0, int secondReference = 0);
}
