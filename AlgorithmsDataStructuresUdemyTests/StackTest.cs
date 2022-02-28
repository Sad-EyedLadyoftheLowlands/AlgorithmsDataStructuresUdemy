using AlgorithmsDataStructuresUdemy;
using Xunit;

namespace AlgorithmsDataStructuresUdemyTests;

public class StackTest
{
    [Fact]
    public void Add_StackLengthIncreases()
    {
        var stack = new Stack();
        stack.Add(1);
        stack.Add(2);
        Assert.Equal(stack.Length, 2); 
    }

    [Fact]
    public void Pop_StackPopsLIFO()
    {
        var stack = new Stack();
        stack.Add(1);
        stack.Add(2);
        Assert.Equal(2, stack.Pop());
    }

    [Fact]
    public void Pop_PopHandlesEmptyStack()
    {
        var stack = new Stack();
        Assert.Equal(null, stack.Pop());
    }
}