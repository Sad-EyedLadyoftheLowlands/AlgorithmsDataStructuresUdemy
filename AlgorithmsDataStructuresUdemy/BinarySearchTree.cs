using System.Collections.Generic;

namespace AlgorithmsDataStructuresUdemy;

public class BinarySearchTree
{
    public BinarySearchTreeNode Root { get; set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public List<int> BreadthFirstSearch()
    {
        var queue = new Queue<BinarySearchTreeNode>();
        var data = new List<int>();

        queue.Enqueue(Root);
        
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            data.Add(currentNode.Value);
            if (currentNode.Left is not null)
                queue.Enqueue(currentNode.Left);
            
            if (currentNode.Right is not null)
                queue.Enqueue(currentNode.Right);
        }

        return data;
    }

    public List<int> DepthFirstSearchPreOrder()
    {
        var data = new List<int>();
        var currentNode = Root;

        return Traverse(currentNode, data);

        List<int> Traverse(BinarySearchTreeNode node, List<int> data)
        {
            data.Add(node.Value);

            if (node.Left is not null)
            {
                Traverse(node.Left, data);
            }
            if (node.Right is not null)
            {
                Traverse(node.Right, data);
            }

            return data;
        } 
    }

    public List<int> DepthFirstSearchPostOrder()
    {
        var data = new List<int>();
        var currentNode = Root;

        return Traverse(currentNode, data);

        List<int> Traverse(BinarySearchTreeNode node, List<int> data)
        {
            if (node.Left is not null)
            {
                Traverse(node.Left, data);
            }
            if (node.Right is not null)
            {
                Traverse(node.Right, data);
            }

            data.Add(node.Value);

            return data;
        }
    }

    public List<int> DepthFirstSearchInOrder()
    {
        var data = new List<int>();
        var currentNode = Root;

        return Traverse(currentNode, data);

        List<int> Traverse(BinarySearchTreeNode node, List<int> data)
        {
            if (node.Left is not null)
            {
                Traverse(node.Left, data);
            }

            data.Add(node.Value);

            if (node.Right is not null)
            {
                Traverse(node.Right, data);
            }

            return data;
        }
    }
    
    public BinarySearchTree InsertRecursive(int value, BinarySearchTreeNode currentNode = null)
    {
        if (Root is null)
        {
            Root = new BinarySearchTreeNode(value);
            return this;
        }

        currentNode ??= Root;

        if (currentNode.Value == value)
        {
            // throw new Exception("Value already exists in tree.");
            return this;
        }

        if (value < currentNode.Value)
        {
            if (currentNode.Left is null)
            {
                currentNode.Left = new BinarySearchTreeNode(value);
                return this;
            }

            InsertRecursive(value, currentNode.Left);
        }
        else
        {
            if (currentNode.Right is null)
            {
                currentNode.Right = new BinarySearchTreeNode(value);
                return this;
            }

            InsertRecursive(value, currentNode.Right);
        }

        return this;
    }

    public bool FindIterative(int value)
    {
        if (Root is null)
            return false;

        if (Root.Value == value)
            return true;
        
        var currentNode = Root;
        while (true)
        {
            if (value < currentNode.Value)
            {
                if (currentNode.Left is null)
                    return false;
                if (value == currentNode.Left.Value)
                    return true;
                currentNode = currentNode.Left;
            }
            else
            {
                if (currentNode.Right is null)
                    return false;
                if (value == currentNode.Right.Value)
                    return true;
                currentNode = currentNode.Right;
            }
        }
    }
    
    public BinarySearchTree InsertIterative(int value)
    {
        var node = new BinarySearchTreeNode(value);

        if (Root is null)
        {
            Root = node;
            return this;
        }
        
        var currentNode = Root;
        
        while (true)
        {
            if (currentNode.Value == value)
            {
                // throw new Exception("Value already exists in tree.");
                return this;
            }
            
            if (value < currentNode.Value)
            {
                if (currentNode.Left is null)
                {
                    // We have the place to insert.
                    currentNode.Left = node;
                    return this;
                }

                // Continue.
                currentNode = currentNode.Left;
            }
            else
            {
                if (currentNode.Right is null)
                {
                    // We have the place to insert.
                    currentNode.Right = node;
                    return this;
                }
                
                // Continue.
                currentNode = currentNode.Right;
            }
        }
    }
}