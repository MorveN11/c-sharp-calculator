namespace Project.Builders;

using Project.Operators;

[TestFixture]
class BinaryOperatorBuilderTests
{
    [Test]
    public void VerifyThat_SetFirstReference_SetsTheFirstReferenceTest()
    {
        // Define input and output
        int firstReference = 1;
        BinaryOperator expected = new BinaryOperator { FirstReference = firstReference };

        BinaryOperatorBuilder binaryOperatorBuilder = new BinaryOperatorBuilder();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorBuilder.SetFirstReference(firstReference).Build();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_SetSecondReference_SetsTheSecondReferenceTest()
    {
        // Define input and output
        int secondReference = 1;
        BinaryOperator expected = new BinaryOperator { SecondReference = secondReference };

        BinaryOperatorBuilder binaryOperatorBuilder = new BinaryOperatorBuilder();

        // Execute actual operation
        BinaryOperator actual = binaryOperatorBuilder.SetSecondReference(secondReference).Build();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
