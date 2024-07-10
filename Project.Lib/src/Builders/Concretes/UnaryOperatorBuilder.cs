namespace Project.Builders;

using Project.Operators;

public class UnaryOperatorBuilder : OperatorBuilder<UnaryOperator>
{
    public UnaryOperatorBuilder SetReference(int reference)
    {
        Operator!.Reference = reference;
        return this;
    }
}
