namespace Project.Builders;

using Project.Operators;

[TestFixture]
class UnaryOperatorBuilderTests
{
    [Test]
    public void VerifyThat_SetReference_SetsTheReferenceTest()
    {
        // Define input and output
        int reference = 1;
        UnaryOperator expected = new UnaryOperator { Reference = reference };

        UnaryOperatorBuilder unaryOperatorBuilder = new UnaryOperatorBuilder();

        // Execute actual operation
        UnaryOperator actual = unaryOperatorBuilder.SetReference(reference).Build();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
