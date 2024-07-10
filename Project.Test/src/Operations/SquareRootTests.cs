namespace Project.Operations;

[TestFixture]
class SquareRootTests
{
    [Test]
    public void VerifyThan_OneOperation_ReturnsCorrectSquareRootTest()
    {
        // Define input and output
        Mock<IOperation> value = new Mock<IOperation>();
        double expected = 5;

        UnaryOperation squareRoot = new SquareRoot(value.Object);

        value.Setup(x => x.GetResult()).Returns(25);

        // GetResult actual operation
        double actual = squareRoot.GetResult();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
