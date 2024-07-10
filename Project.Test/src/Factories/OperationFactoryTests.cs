namespace Project.Factories;

using Project.Models;
using Project.Operations;
using Project.Operators;

[TestFixture]
class OperationFactoryTests
{
    [Test]
    public void VerifyThan_CreateBinaryOperation_WithTwoOperationsAndBinaryOperator_ReturnsTheCorrectOperationTest()
    {
        // Define input and output
        Mock<IBinaryOperator> operationType = new Mock<IBinaryOperator>();
        Mock<IOperation> firstValue = new Mock<IOperation>();
        Mock<IOperation> secondValue = new Mock<IOperation>();

        OperationFactory factory = new OperationFactory();

        operationType.Setup(x => x.Provenance).Returns(OperatorProvenance.Add);

        // Execute actual operation
        IOperation actual = factory.Create(
            operationType.Object,
            firstValue.Object,
            secondValue.Object
        );

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<Add>());
    }

    [Test]
    public void VerifyThan_CreateUnaryOperation_WithOneOperationAndUnaryOperator_ReturnsTheCorrectOperationTest()
    {
        // Define input and output
        Mock<IUnaryOperator> operationType = new Mock<IUnaryOperator>();
        Mock<IOperation> value = new Mock<IOperation>();

        OperationFactory factory = new OperationFactory();

        operationType.Setup(x => x.Provenance).Returns(OperatorProvenance.Square);

        // Execute actual operation
        IOperation actual = factory.Create(operationType.Object, value.Object);

        // Verify actual result
        Assert.That(actual, Is.InstanceOf<Square>());
    }
}
