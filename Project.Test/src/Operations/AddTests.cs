namespace Project.Operations;

[TestFixture]
class AddTests
{
    [Test]
    public void VerifyThan_TwoOperations_ReturnsCorrectSumTest()
    {
        // Define input and output
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();
        double expected = 30;

        IOperation value = new Add(firstValue.Object, secondValue.Object);

        firstValue.Setup(x => x.Execute()).Returns(10);
        secondValue.Setup(x => x.Execute()).Returns(20);

        // Execute actual operation
        double actual = value.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
