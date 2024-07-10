namespace Project.Operators;

public interface IBinaryOperator : IOperator
{
    int FirstReference { get; set; }
    int SecondReference { get; set; }
}
