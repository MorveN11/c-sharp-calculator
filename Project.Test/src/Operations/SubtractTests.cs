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

        IOperation value = new Subtract(firstValue.Object, secondValue.Object);

        firstValue.Setup(x => x.Execute()).Returns(100);
        secondValue.Setup(x => x.Execute()).Returns(90);

        // Execute actual operation
        double actual = value.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
