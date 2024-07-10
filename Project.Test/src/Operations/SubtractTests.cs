namespace Project.Operations;

[TestFixture]
class SubtractTests
{
    [Test]
    public void VerifyThan_TwoOperations_ReturnsCorrectSubtractTest()
    {
        // Define input and output
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();
        double expected = 10;

        BinaryOperation value = new Subtract(firstValue.Object, secondValue.Object);

        firstValue.Setup(x => x.GetResult()).Returns(100);
        secondValue.Setup(x => x.GetResult()).Returns(90);

        // GetResult actual operation
        double actual = value.GetResult();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
