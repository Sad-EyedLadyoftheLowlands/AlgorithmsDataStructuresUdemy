using System;

namespace AlgorithmsDataStructuresUdemy;

public class Stack
{
    private SingleLinkedList _linkedList;

    public int Length => _linkedList.Length;
    
    public Stack()
    {
        _linkedList = new SingleLinkedList();
    }

    public int Add(int value)
    {
        _linkedList.UnShift(value);
        return _linkedList.Length;
    }

    public int? Pop()
    {
        var result = _linkedList.Shift();
        if (result is null)
            return null;
                
        return _linkedList.Shift().Value;
    }
}