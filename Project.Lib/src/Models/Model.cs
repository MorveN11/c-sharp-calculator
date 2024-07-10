namespace Project.Models;

using Project.Utils;

public enum OperatorProvenance
{
    None = 0,
    Subtract = 1,
    Add = 2,
    Divide = 3,
    Multiply = 4,
    Square = 5,
    SquareRoot = ProjectConstants.MaxProvenance
}
