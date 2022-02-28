using System;

namespace AlgorithmsDataStructuresUdemy;

public class SingleLinkedList
{
    private int _length;
    private SingleLinkedListNode _head;
    private SingleLinkedListNode _tail;

    public int Length => _length;

    public SingleLinkedList()
    {
        _length = 0;
        _head = null; 
        _tail = null;
    }

    public void Push(int value)
    {
        var node = new SingleLinkedListNode(value);
            
        if (_head == null)
        {
            _head = node;
            _tail = _head;
        }
        else
        {
            _tail.Next = node;
            _tail = node;
        }

        _length++;
    }

    public SingleLinkedListNode Pop()
    {
        if (_length == 0) return null; 

        var current = _head;
        var newTail = current;

        while (current.Next != null)
        {
            newTail = current;
            current = current.Next;
        }

        _tail = newTail;
        _tail.Next = null;

        _length--;
            
        // Final check if list is now empty.
        if (_length == 0)
        {
            _head = null;
            _tail = null;
        }

        return current;
    }

    public SingleLinkedListNode Shift()
    {
        SingleLinkedListNode head;
            
        switch (_length)
        {
            case 0:
                return null;
            case 1:
                head = _head;
                _head = null;
                _tail = null;
                _length = 0;
                return head;
        }

        head = _head;
        _head = head.Next;
        _length--;
            
        return head;
    }

    public void UnShift(int value)
    {
        var node = new SingleLinkedListNode(value);
            
        if (_length == 0)
        {
            _head = node;
            _tail = _head;
            _length = 1;
        }
        else
        {
            node.Next = _head;
            _head = node;
            _length++;
        }
    }

    public SingleLinkedListNode GetByIndex(int index)
    {
        if (index >= _length || index < 0) return null;
        if (index == 0) return _head;

        var node = _head;
            
        for (var i = 0; i < index; i++)
        {
            node = node.Next;
        }

        return node;
    }

    public void SetByIndex(int index, int value)
    {
        var node = GetByIndex(index);

        if (node == null) return;

        node.Value = value;
    }

    public void Insert(int index, int value)
    {
        if (index < 0 || index > _length) return;
        if (index == _length) Push(value);
        if (index == 0) UnShift(value);

        var node = new SingleLinkedListNode(value);
        var prev = GetByIndex(index - 1);

        node.Next = prev.Next;
        prev.Next = node;

        _length++;
    }

    public void RemoveByIndex(int index)
    {
        if (index < 0 || index > _length) return;
        if (index == _length - 1) Pop();
        if (index == 0) Shift();
        else
        {
            var node = GetByIndex(index - 1);
            node.Next = node.Next.Next;
            _length--;
        }
    }

    public void ReverseInPlace()
    {
        if (_length == 0) return;
            
        var node = _head;
        (_head, _tail) = (_tail, _head);

        SingleLinkedListNode previous = null;

        for (var i = 0; i < _length; i++)
        {
            var next = node.Next;
            node.Next = previous;
            previous = node;
            node = next;
        }
    }

    public void Print()
    {
        if (_length == 0) return;
            
        Console.WriteLine($"HEAD: {_head.Value}");

        var current = _head.Next;
            
        for (int i = 1; i < _length - 1; i++)
        {
            Console.WriteLine($"Value at {i} level(s) deep: {current.Value}");
            current = current.Next;
        }
            
        Console.WriteLine($"TAIL: {_tail.Value}");
    }
}