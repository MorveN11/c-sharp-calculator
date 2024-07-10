namespace Project.Builders;

using Project.Operators;

public class BinaryOperatorBuilder : OperatorBuilder<BinaryOperator>
{
    public BinaryOperatorBuilder SetFirstReference(int reference)
    {
        Operator!.FirstReference = reference;
        return this;
    }

    public BinaryOperatorBuilder SetSecondReference(int reference)
    {
        Operator!.SecondReference = reference;
        return this;
    }
}
