namespace Project.Factories;

using Project.Models;
using Project.Operations;

[TestFixture]
class OperationFactoryTests
{
    public void VerifyThan_CreateUnaryOperation_ReturnsTheCorrectEnumTypeTest()
    {
        // Define input and output
        Mock<BinaryOperationType> operationType = new Mock<BinaryOperationType>();
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();

        IOperationFactory factory = new OperationFactory();

        operationType.Setup(x => x.Provenance).Returns(1);

        // Execute actual operation
        IOperation actual = factory.Create(
            operationType.Object,
            firstValue.Object,
            secondValue.Object
        );

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<Add>());
    }

    public void VerifyThan_CreateBinaryOperation_ReturnsTheCorrectEnumTypeTest()
    {
        // Define input and output
        Mock<UnaryOperationType> operationType = new Mock<UnaryOperationType>();
        Mock<IOperation> value = new Mock<IOperation>();

        IOperationFactory factory = new OperationFactory();

        operationType.Setup(x => x.Provenance).Returns(5);

        // Execute actual operation
        IOperation actual = factory.Create(operationType.Object, value.Object);

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<Square>());
    }
}
