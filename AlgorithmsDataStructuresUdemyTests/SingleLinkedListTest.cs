using AlgorithmsDataStructuresUdemy;
using Xunit;

namespace AlgorithmsDataStructuresUdemyTests;

public class SingleLinkedListTest
{
    [Fact]
    public void TestSingleLinkedListIsCreated()
    {
        var list = new SingleLinkedList();
        Assert.IsType<SingleLinkedList>(list);
    }

    [Fact]
    public void SingleLinkedList_CreatedListHasLengthZero()
    {
        var list = new SingleLinkedList();
        Assert.True(list.Length == 0);
    }

    [Fact]
    public void Push_PushIncreasesLengthProperty()
    {
        var list = new SingleLinkedList();
        var length = list.Length;
        list.Push(1);
        Assert.True(list.Length > length);
    }

    [Fact]
    public void Pop_PopReturnsNullWhenLengthIsZero()
    {
        var list = new SingleLinkedList();
        var result = list.Pop();
        Assert.True(result == null);
    }

    [Fact]
    public void ReverseInPlace_ListIsReversed()
    {
        var list = new SingleLinkedList();
        list.Push(1);
        list.Push(2); 
        list.Push(3);
        list.ReverseInPlace();


        var third = list.Pop();
        var second = list.Pop();
        var first = list.Pop();

        Assert.True(third.Value == 1);
        Assert.True(second.Value == 2);
        Assert.True(first.Value == 3);
    }

}