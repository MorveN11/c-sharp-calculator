namespace Project.Parsers;

using Project.Nodes;
using Project.Operations;

[TestFixture]
class InputOperandsParserTests
{
    [Test]
    public void VerifyThan_ParseSimpleInput_ReturnsCorrectOperandsTest()
    {
        // Define input and output
        IList<INode> expected =
        [
            new Node(new Operand(10), 0),
            new Node(new Operand(20), 1),
            new Node(new Operand(30), 2),
            new Node(new Operand(40), 3)
        ];
        string input = "10 + 20 - 30 + ~ 40";

        InputOperandsParser parser = new InputOperandsParser();

        // Execute actual operation
        IList<INode> actual = parser.Parse(input);

        // Verify actual result
        Assert.That(actual, Is.EqualTo(expected));
    }
}
