namespace Project.Operations;

[TestFixture]
class MultiplyTests
{
    [Test]
    public void VerifyThan_TwoOperations_ReturnsCorrectMultiplyTests()
    {
        // Define input and output
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();
        double expected = 100;

        BinaryOperation value = new Multiply(firstValue.Object, secondValue.Object);

        firstValue.Setup(x => x.GetResult()).Returns(4);
        secondValue.Setup(x => x.GetResult()).Returns(25);

        // GetResult actual operation
        double actual = value.GetResult();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
