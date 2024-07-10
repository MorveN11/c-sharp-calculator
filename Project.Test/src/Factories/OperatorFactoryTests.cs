namespace Project.Factories;

using Project.Directors;
using Project.Models;
using Project.Operators;

[TestFixture]
class OperatorFactoryTests
{
    [Test]
    public void VerifyThan_SumOperator_ReturnsTheCorrectOperatorTest()
    {
        // Define input and output
        Mock<IBinaryOperatorDirector> binaryOperatorDirector = new Mock<IBinaryOperatorDirector>();
        Mock<IUnaryOperatorDirector> unaryOperatorDirector = new Mock<IUnaryOperatorDirector>();
        string input = "+";
        IOperator expected = new BinaryOperator { Provenance = OperatorProvenance.Add };

        OperatorFactory operatorFactory = new OperatorFactory(
            binaryOperatorDirector.Object,
            unaryOperatorDirector.Object
        );

        binaryOperatorDirector
            .Setup(x => x.ConstructAddOperator(It.IsAny<int>(), It.IsAny<int>()))
            .Returns(new BinaryOperator { Provenance = OperatorProvenance.Add });

        // Execute actual operation
        IOperator actual = operatorFactory.Create(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
