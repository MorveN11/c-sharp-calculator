namespace Project.Operations;

using NUnit.Framework;

[TestFixture]
public class ValueTests
{
    [Test]
    public void VerifyThan_InputValue_ReturnsTheSameValueTest()
    {
        // Define input and output
        double input = 4;
        double expected = 4;
        IOperation value = new Value(input);

        // Execute actual operation
        double actual = value.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
