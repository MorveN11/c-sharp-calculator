namespace Project.Utils;

using System.Text.RegularExpressions;

public static partial class ProjectConstants
{
    public const int MaxProvenance = 6;

    [GeneratedRegex(@"[\+\-~/*^]")]
    public static partial Regex Operator();

    [GeneratedRegex(@"\d+")]
    public static partial Regex Operand();
}
