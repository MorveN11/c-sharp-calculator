namespace Project.Operations;

[TestFixture]
class DivideTests
{
    [Test]
    public void VerifyThan_TwoOperations_ReturnCorrectDivideTest()
    {
        // Define input and output
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();
        double expected = 5;

        BinaryOperation value = new Divide(firstValue.Object, secondValue.Object);

        firstValue.Setup(x => x.Execute()).Returns(25);
        secondValue.Setup(x => x.Execute()).Returns(5);

        // Execute actual operation
        double actual = value.Execute();

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
