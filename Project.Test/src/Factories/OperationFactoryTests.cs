namespace Project.Factories;

using Project.Models;
using Project.Operations;

[TestFixture]
class OperationFactoryTests
{
    public void VerifyThan_CreateUnaryOperation_ReturnsTheCorrectEnumTypeTest()
    {
        // Define input and output
        BinaryOperationType operationType = BinaryOperationType.Add;
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();

        IOperationFactory factory = new OperationFactory();

        // Execute actual operation
        IOperation actual = factory.Create(operationType, firstValue.Object, secondValue.Object);

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<Add>());
    }

    public void VerifyThan_CreateBinaryOperation_ReturnsTheCorrectEnumTypeTest()
    {
        // Define input and output
        UnaryOperationType operationType = UnaryOperationType.SquareRoot;
        Mock<IOperation> value = new Mock<IOperation>();

        IOperationFactory factory = new OperationFactory();

        // Execute actual operation
        IOperation actual = factory.Create(operationType, value.Object);

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<SquareRoot>());
    }
}
