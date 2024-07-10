namespace Project.Directors;

using Project.Models;
using Project.Operators;

[TestFixture]
class UnaryOperatorDirectorTests
{
    [Test]
    public void VerifyThat_ConstructSquareOperator_ConstructsTheCorrectOperatorTest()
    {
        // Define input and output
        int reference = 1;
        UnaryOperator expected = new UnaryOperator
        {
            Reference = reference,
            Provenance = OperatorProvenance.Square
        };

        UnaryOperatorDirector unaryOperatorDirector = new UnaryOperatorDirector();

        // Execute actual operation
        UnaryOperator actual = unaryOperatorDirector.ConstructSquareOperator(reference);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_ConstructSquareRootOperator_ConstructsTheCorrectOperatorTest()
    {
        // Define input and output
        int reference = 1;
        UnaryOperator expected = new UnaryOperator
        {
            Reference = reference,
            Provenance = OperatorProvenance.SquareRoot
        };

        UnaryOperatorDirector unaryOperatorDirector = new UnaryOperatorDirector();

        // Execute actual operation
        UnaryOperator actual = unaryOperatorDirector.ConstructSquareRootOperator(reference);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
