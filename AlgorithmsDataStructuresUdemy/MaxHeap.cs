using System.Collections.Generic;

namespace AlgorithmsDataStructuresUdemy;

public class MaxHeap
{
    private List<int> _backingList;

    public MaxHeap()
    {

    }

    public MaxHeap BubbleInsert(int value)
    {
        _backingList.Add(value);

        return this;
    }
}