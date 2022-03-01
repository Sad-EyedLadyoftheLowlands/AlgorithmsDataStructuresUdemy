using AlgorithmsDataStructuresUdemy;
using Xunit;

namespace AlgorithmsDataStructuresUdemyTests;

public class BinarySearchTreeTest
{
    [Fact]
    public void FindIterative_FindsAddedValue()
    {
        var bst = new BinarySearchTree();
        for (int i = 0; i < 10; i++)
        {
            bst.InsertIterative(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Assert.True(bst.FindIterative(i));
        }
    }
}