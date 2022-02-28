namespace AlgorithmsDataStructuresUdemy;

public class Queue
{
    private SingleLinkedList _linkedList;

    public int Length => _linkedList.Length;
    
    public Queue()
    {
        _linkedList = new SingleLinkedList();
    }

    public void Enqueue(int value)
    {
        _linkedList.Push(value);
    }

    public int? DeQueue()
    {
        var result = _linkedList.Shift();
        if (result is null)
            return null;
        
        return _linkedList.Shift().Value;
    }
}