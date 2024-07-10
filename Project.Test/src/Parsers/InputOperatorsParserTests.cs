namespace Project.Parsers;

using Project.Factories;
using Project.Models;
using Project.Operators;

[TestFixture]
class InputOperatorsParserTests
{
    [Test]
    public void VerifyThan_ParseSimpleInput_ReturnsCorrectOperatorsTest()
    {
        // Define input and output
        Mock<IOperatorFactory> factory = new Mock<IOperatorFactory>();
        string input = "10 + 20 - 30 + ~ 40";

        IList<IOperator> expected =
        [
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
                Provenance = OperatorProvenance.Subtract
            },
            new BinaryOperator
            {
                FirstReference = 2,
                SecondReference = 3,
                Provenance = OperatorProvenance.Add
            },
            new UnaryOperator { Reference = 3, Provenance = OperatorProvenance.SquareRoot }
        ];

        InputOperatorsParser parser = new InputOperatorsParser(factory.Object);

        factory
            .Setup(x => x.Create("+"))
            .Returns(() => new BinaryOperator { Provenance = OperatorProvenance.Add });
        factory
            .Setup(x => x.Create("-"))
            .Returns(() => new BinaryOperator { Provenance = OperatorProvenance.Subtract });
        factory
            .Setup(x => x.Create("~"))
            .Returns(() => new UnaryOperator { Provenance = OperatorProvenance.SquareRoot });

        // Execute actual operation
        IList<IOperator> actual = parser.Parse(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
