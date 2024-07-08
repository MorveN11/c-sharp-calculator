namespace Project.Operations;

[TestFixture]
class SquareTests
{
    [Test]
    public void VerifyThan_OneOperation_ReturnsCorrectSquareTest()
    {
        // Define input and output
        Mock<IOperation> value = new Mock<IOperation>();
        double expected = 25;

        UnaryOperation squareRoot = new Square(value.Object);

        value.Setup(x => x.Execute()).Returns(5);

        // Execute actual operation
        double actual = squareRoot.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
