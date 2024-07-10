namespace Project.Operators;

using Project.Models;

public interface IOperator
{
    OperatorProvenance Provenance { get; set; }
}
