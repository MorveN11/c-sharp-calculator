namespace Project.Directors;

using Project.Models;
using Project.Operators;

[TestFixture]
class BinaryOperatorDirectorTests
{
    [Test]
    public void VerifyThat_ConstructSubtractOperator_ConstructsSubtractOperatorTest()
    {
        // Define input and output
        int firstReference = 1;
        int secondReference = 1;
        BinaryOperator expected = new BinaryOperator
        {
            FirstReference = firstReference,
            SecondReference = secondReference,
            Provenance = OperatorProvenance.Subtract
        };

        BinaryOperatorDirector binaryOperatorDirector = new BinaryOperatorDirector();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorDirector.ConstructSubtractOperator(
            firstReference,
            secondReference
        );

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_ConstructAddOperator_ConstructsAddOperatorTest()
    {
        // Define input and output
        int firstReference = 1;
        int secondReference = 1;
        BinaryOperator expected = new BinaryOperator
        {
            FirstReference = firstReference,
            SecondReference = secondReference,
            Provenance = OperatorProvenance.Add
        };

        BinaryOperatorDirector binaryOperatorDirector = new BinaryOperatorDirector();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorDirector.ConstructAddOperator(
            firstReference,
            secondReference
        );

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_ConstructDivideOperator_ConstructsDivideOperatorTest()
    {
        // Define input and output
        int firstReference = 1;
        int secondReference = 1;
        BinaryOperator expected = new BinaryOperator
        {
            FirstReference = firstReference,
            SecondReference = secondReference,
            Provenance = OperatorProvenance.Divide
        };

        BinaryOperatorDirector binaryOperatorDirector = new BinaryOperatorDirector();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorDirector.ConstructDivideOperator(
            firstReference,
            secondReference
        );

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_ConstructMultiplyOperator_ConstructsMultiplyOperatorTest()
    {
        // Define input and output
        int firstReference = 1;
        int secondReference = 1;
        BinaryOperator expected = new BinaryOperator
        {
            FirstReference = firstReference,
            SecondReference = secondReference,
            Provenance = OperatorProvenance.Multiply
        };

        BinaryOperatorDirector binaryOperatorDirector = new BinaryOperatorDirector();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorDirector.ConstructMultiplyOperator(
            firstReference,
            secondReference
        );

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
