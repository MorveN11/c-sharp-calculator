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

        value.Setup(x => x.GetResult()).Returns(5);

        // GetResult actual operation
        double actual = squareRoot.GetResult();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
