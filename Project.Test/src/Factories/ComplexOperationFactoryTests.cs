namespace Project.Factories;

using Project.Models;
using Project.Nodes;
using Project.Operations;
using Project.Operators;
using Project.Parsers;

[TestFixture]
class ComplexOperationFactoryTests
{
    [Test]
    public void VerifyThat_CreateComplexOperationInput_CreatesComplexOperationTest()
    {
        // Define input and output
        Mock<IInputOperandsParser> operandsParser = new Mock<IInputOperandsParser>();
        Mock<IInputOperatorsParser> operatorsParser = new Mock<IInputOperatorsParser>();
        string input = "10 + ^ 2 * 20";
        IOperation expected = new Add(
            new Operand(10),
            new Multiply(new Square(new Operand(2)), new Operand(20))
        );

        ComplexOperationFactory factory = new ComplexOperationFactory(
            operandsParser.Object,
            operatorsParser.Object
        );

        operandsParser
            .Setup(x => x.Parse(input))
            .Returns(
                () =>
                    new List<INode>
                    {
                        new Node(new Operand(10), 0),
                        new Node(new Operand(2), 1),
                        new Node(new Operand(20), 2),
                    }
            );

        operatorsParser
            .Setup(x => x.Parse(input))
            .Returns(
                () =>
                    new List<IOperator>
                    {
                        new BinaryOperator
                        {
                            FirstReference = 0,
                            SecondReference = 1,
                            Provenance = OperatorProvenance.Add
                        },
                        new UnaryOperator { Reference = 1, Provenance = OperatorProvenance.Square },
                        new BinaryOperator
                        {
                            FirstReference = 1,
                            SecondReference = 2,
                            Provenance = OperatorProvenance.Multiply
                        },
                    }
            );

        // Execute actual operation
        IOperation actual = factory.Create(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void VerifyThat_CreateComplexOperationWithAllOperatorsInput_CreatesComplexOperationTest()
    {
        // Define input and output
        Mock<IInputOperandsParser> operandsParser = new Mock<IInputOperandsParser>();
        Mock<IInputOperatorsParser> operatorsParser = new Mock<IInputOperatorsParser>();
        string input = "10 + 2 * 5 + ~ 9 + 4 - ^ 6 / 2";
        IOperation expected = new Subtract(
            new Add(
                new Add(
                    new Add(new Operand(10), new Multiply(new Operand(2), new Operand(5))),
                    new SquareRoot(new Operand(9))
                ),
                new Operand(4)
            ),
            new Divide(new Square(new Operand(6)), new Operand(2))
        );

        ComplexOperationFactory factory = new ComplexOperationFactory(
            operandsParser.Object,
            operatorsParser.Object
        );

        operandsParser
            .Setup(x => x.Parse(input))
            .Returns(
                () =>
                    new List<INode>
                    {
                        new Node(new Operand(10), 0),
                        new Node(new Operand(2), 1),
                        new Node(new Operand(5), 2),
                        new Node(new Operand(9), 3),
                        new Node(new Operand(4), 4),
                        new Node(new Operand(6), 5),
                        new Node(new Operand(2), 6),
                    }
            );

        operatorsParser
            .Setup(x => x.Parse(input))
            .Returns(
                () =>
                    new List<IOperator>
                    {
                        new BinaryOperator
                        {
                            FirstReference = 0,
                            SecondReference = 1,
                            Provenance = OperatorProvenance.Add
                        },
                        new BinaryOperator
                        {
                            FirstReference = 1,
                            SecondReference = 2,
                            Provenance = OperatorProvenance.Multiply
                        },
                        new BinaryOperator
                        {
                            FirstReference = 2,
                            SecondReference = 3,
                            Provenance = OperatorProvenance.Add
                        },
                        new UnaryOperator
                        {
                            Reference = 3,
                            Provenance = OperatorProvenance.SquareRoot
                        },
                        new BinaryOperator
                        {
                            FirstReference = 3,
                            SecondReference = 4,
                            Provenance = OperatorProvenance.Add
                        },
                        new BinaryOperator
                        {
                            FirstReference = 4,
                            SecondReference = 5,
                            Provenance = OperatorProvenance.Subtract
                        },
                        new UnaryOperator { Reference = 5, Provenance = OperatorProvenance.Square },
                        new BinaryOperator
                        {
                            FirstReference = 5,
                            SecondReference = 6,
                            Provenance = OperatorProvenance.Divide
                        },
                    }
            );

        // Execute actual operation
        IOperation actual = factory.Create(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
