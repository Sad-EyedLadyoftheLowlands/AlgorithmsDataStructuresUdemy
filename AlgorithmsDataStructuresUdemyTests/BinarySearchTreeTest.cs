using AlgorithmsDataStructuresUdemy;
using System.Collections.Generic;
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

    [Fact]
    public void BreadthFirstSearch_ReturnsProperList()
    {
        var bst = new BinarySearchTree();
        bst.InsertIterative(10);
        bst.InsertIterative(5);
        bst.InsertIterative(15);
        bst.InsertIterative(3);
        bst.InsertIterative(20);

        var result = bst.BreadthFirstSearch();
        Assert.True(result.Count == 5);
    }

    [Fact]
    public void DepthFirstSearchPostOrder_ReturnsProperList()
    {
        var bst = new BinarySearchTree();
        bst.InsertIterative(10);
        bst.InsertIterative(6);
        bst.InsertIterative(15);
        bst.InsertIterative(20);
        bst.InsertIterative(3);
        bst.InsertIterative(8);
        
        var result = bst.DepthFirstSearchPostOrder();
        var comparison = new List<int> { 3,8,6,20,15,10 };

        Assert.True(result.Count == comparison.Count);

        for (int i = 0; i < result.Count - 1; i++)
        {
            Assert.True(result[i] == comparison[i]);
        }
    }

    [Fact]
    public void DepthFirstSearchPreOrder_ReturnsProperList()
    {
        var bst = new BinarySearchTree();
        bst.InsertIterative(10);
        bst.InsertIterative(6);
        bst.InsertIterative(15);
        bst.InsertIterative(20);
        bst.InsertIterative(3);
        bst.InsertIterative(8);
        
        var result = bst.DepthFirstSearchPreOrder();
        var comparison = new List<int> { 10,6,3,8,15,20 };

        Assert.True(result.Count == comparison.Count);

        for (int i = 0; i < result.Count - 1; i++)
        {
            Assert.True(result[i] == comparison[i]);
        }
    }

    [Fact]
    public void DepthFirstSearchInOrder_ReturnsProperList()
    {
        var bst = new BinarySearchTree();
        bst.InsertIterative(10);
        bst.InsertIterative(6);
        bst.InsertIterative(15);
        bst.InsertIterative(20);
        bst.InsertIterative(3);
        bst.InsertIterative(8);
        
        var result = bst.DepthFirstSearchInOrder();
        var comparison = new List<int> { 3,6,8,10,15,20 };

        Assert.True(result.Count == comparison.Count);

        for (int i = 0; i < result.Count - 1; i++)
        {
            Assert.True(result[i] == comparison[i]);
        }
    }
}