namespace Project.Directors;

using Project.Builders;
using Project.Models;
using Project.Operators;

public class BinaryOperatorDirector
    : OperatorDirector<BinaryOperatorBuilder, BinaryOperator>,
        IBinaryOperatorDirector
{
    public BinaryOperatorDirector()
        : base() { }

    public BinaryOperator ConstructSubtractOperator(int firstReference = 0, int secondReference = 0)
    {
        return Builder
            .SetFirstReference(firstReference)
            .SetSecondReference(secondReference)
            .SetProvenance(OperatorProvenance.Subtract)
            .Build();
    }

    public BinaryOperator ConstructAddOperator(int firstReference = 0, int secondReference = 0)
    {
        return Builder
            .SetFirstReference(firstReference)
            .SetSecondReference(secondReference)
            .SetProvenance(OperatorProvenance.Add)
            .Build();
    }

    public BinaryOperator ConstructDivideOperator(int firstReference = 0, int secondReference = 0)
    {
        return Builder
            .SetFirstReference(firstReference)
            .SetSecondReference(secondReference)
            .SetProvenance(OperatorProvenance.Divide)
            .Build();
    }

    public BinaryOperator ConstructMultiplyOperator(int firstReference = 0, int secondReference = 0)
    {
        return Builder
            .SetFirstReference(firstReference)
            .SetSecondReference(secondReference)
            .SetProvenance(OperatorProvenance.Multiply)
            .Build();
    }
}
