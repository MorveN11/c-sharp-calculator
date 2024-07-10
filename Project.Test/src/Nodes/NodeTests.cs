namespace Project.Nodes;

using Project.Operations;

[TestFixture]
class NodeTests
{
    [Test]
    public void VerifyThan_OperationWIthParent_CreateCorrectlyANodeTest()
    {
        // Define input and output
        Mock<IOperation> operationMock = new Mock<IOperation>();
        int parent = 10;
        IOperation expectedOperation = operationMock.Object;
        int expectedParent = 10;

        Node node = new Node(operationMock.Object, parent);

        // Execute actual operation
        IOperation actualOperation = node.Operation!;
        int actualParent = node.Parent;

        // Verify actual result
        Assert.That(actualOperation, Is.EqualTo(expectedOperation));
        Assert.That(actualParent, Is.EqualTo(expectedParent));
    }
}
