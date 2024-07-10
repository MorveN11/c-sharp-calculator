namespace Project;

using Project.Factories;
using Project.Operations;

[TestFixture]
class CalculatorTests
{
    [Test]
    public void Calculate_WhenGivenExpression_ReturnsCorrectResult()
    {
        // Define input and output
        string expression = "10 + ^ 2 * 20";
        double expectedResult = 90;
        Mock<IComplexOperationFactory> complexOperationFactory =
            new Mock<IComplexOperationFactory>();

        Calculator calculator = new Calculator(complexOperationFactory.Object);

        complexOperationFactory
            .Setup(x => x.Create(expression))
            .Returns(
                () =>
                    new Add(
                        new Operand(10),
                        new Multiply(new Square(new Operand(2)), new Operand(20))
                    )
            );
        ;

        // Execute actual operation
        double result = calculator.Calculate(expression);

        // Verify actual result
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Calculate_WhenGivenComplexExpression_ReturnsCorrectResult()
    {
        string input = "10 + 2 * 5 + ~ 9 + 4 - ^ 6 / 2";
        double expectedResult = 9;
        Mock<IComplexOperationFactory> complexOperationFactory =
            new Mock<IComplexOperationFactory>();

        Calculator calculator = new Calculator(complexOperationFactory.Object);

        complexOperationFactory
            .Setup(x => x.Create(input))
            .Returns(
                () =>
                    new Subtract(
                        new Add(
                            new Add(
                                new Add(
                                    new Operand(10),
                                    new Multiply(new Operand(2), new Operand(5))
                                ),
                                new SquareRoot(new Operand(9))
                            ),
                            new Operand(4)
                        ),
                        new Divide(new Square(new Operand(6)), new Operand(2))
                    )
            );

        // Execute actual operation
        double result = calculator.Calculate(input);

        // Verify actual result
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
