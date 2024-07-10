namespace Project.Operators;

[TestFixture]
class UnaryOperatorTests
{
    [Test]
    public void VerifyThan_Constructor_Initializes_References()
    {
        // Define input and output
        int reference = 10;
        int expectedReference = 10;

        IUnaryOperator unaryOperator = new UnaryOperator(reference);

        // Execute actual operation
        int actualReference = unaryOperator.Reference;

        // Verify actual result
        Assert.That(actualReference, Is.EqualTo(expectedReference));
    }
}
