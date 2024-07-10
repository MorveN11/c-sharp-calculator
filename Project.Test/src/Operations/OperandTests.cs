namespace Project.Operations;

[TestFixture]
class OperandTests
{
    [Test]
    public void VerifyThan_InputValue_ReturnsTheSameValueTest()
    {
        // Define input and output
        double input = 4;
        double expected = 4;

        Operand value = new Operand(input);

        // GetResult actual operation
        double actual = value.GetResult();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
