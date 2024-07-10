namespace Project.Parsers;

using Project.Directors;
using Project.Factories;
using Project.Operators;

[TestFixture]
class InputOperatorsParserTests
{
    private IBinaryOperatorDirector? _binaryOperatorDirector;
    private IUnaryOperatorDirector? _unaryOperatorDirector;

    [SetUp]
    public void SetUp()
    {
        _binaryOperatorDirector = new BinaryOperatorDirector();
        _unaryOperatorDirector = new UnaryOperatorDirector();
    }

    [Test]
    public void VerifyThan_ParseSimpleInput_ReturnsCorrectOperatorsTest()
    {
        // Define input and output
        Mock<IOperatorFactory> factory = new Mock<IOperatorFactory>();
        string input = "10 + 20 - 30 + ~ 40";

        IList<IOperator> expected =
        [
            _binaryOperatorDirector!.ConstructAddOperator(0, 1),
            _binaryOperatorDirector.ConstructSubtractOperator(1, 2),
            _binaryOperatorDirector.ConstructAddOperator(2, 3),
            _unaryOperatorDirector!.ConstructSquareRootOperator(3)
        ];

        IInputOperatorsParser parser = new InputOperatorsParser(factory.Object);

        factory
            .Setup(x => x.Create("+"))
            .Returns(() => _binaryOperatorDirector.ConstructAddOperator());
        factory
            .Setup(x => x.Create("-"))
            .Returns(() => _binaryOperatorDirector.ConstructSubtractOperator());
        factory
            .Setup(x => x.Create("~"))
            .Returns(() => _unaryOperatorDirector.ConstructSquareRootOperator());

        // Execute actual operation
        IList<IOperator> actual = parser.Parse(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
