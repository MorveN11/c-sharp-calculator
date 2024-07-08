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

        IOperation squareRoot = new SquareRoot(value.Object);

        value.Setup(x => x.Execute()).Returns(25);

        // Execute actual operation
        double actual = squareRoot.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
