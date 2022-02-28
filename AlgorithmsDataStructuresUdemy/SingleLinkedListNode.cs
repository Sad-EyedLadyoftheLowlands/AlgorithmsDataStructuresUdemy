namespace AlgorithmsDataStructuresUdemy;

public class SingleLinkedListNode
{
    public int Value { get; set; }
    public SingleLinkedListNode Next { get; set; }

    public SingleLinkedListNode(int val)
    {
        Value = val;
        Next = null;
    }
}
