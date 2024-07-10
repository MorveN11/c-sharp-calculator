using System.Text.RegularExpressions;

namespace Project.Utils;

public static partial class ProjectConstants
{
    public const int MaxProvenance = 6;

    [GeneratedRegex(@"[\+\-~/*^]")]
    public static partial Regex Operator();

    [GeneratedRegex(@"\d+")]
    public static partial Regex Operand();
}
