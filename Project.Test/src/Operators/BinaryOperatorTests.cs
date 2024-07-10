namespace Project.Operators;

[TestFixture]
class BinaryOperatorTests
{
    [Test]
    public void VerifyThan_Constructor_Initializes_References()
    {
        // Define input and output
        int firstReference = 10;
        int secondReference = 20;
        int expectedFirstReference = 10;
        int expectedSecondReference = 20;

        IBinaryOperator binaryOperator = new BinaryOperator(firstReference, secondReference);

        // Execute actual operation
        int actualFirstReference = binaryOperator.FirstReference;
        int actualSecondReference = binaryOperator.SecondReference;

        // Verify actual result
        Assert.That(actualFirstReference, Is.EqualTo(expectedFirstReference));
        Assert.That(actualSecondReference, Is.EqualTo(expectedSecondReference));
    }
}
