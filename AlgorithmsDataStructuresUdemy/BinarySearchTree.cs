using System;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace AlgorithmsDataStructuresUdemy;

public class BinarySearchTree
{
    public BinarySearchTreeNode Root { get; set; }

    public BinarySearchTree()
    {
        Root = null;
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