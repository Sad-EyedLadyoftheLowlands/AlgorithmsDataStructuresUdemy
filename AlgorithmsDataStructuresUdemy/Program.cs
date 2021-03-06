using System;
using System.Collections.Generic;
using AlgorithmsDataStructuresUdemy;
using BenchmarkDotNet.Running;

// BenchmarkRunner.Run<AlgorithmsDataStructuresUdemy.BenchmarkRunner>();

var bst1 = new BinarySearchTree();
var bst2 = new BinarySearchTree();
var random = new Random();

bst2.InsertIterative(50);

for (int i = 0; i < 100; i++)
{
    var next = random.Next(0, 100);
    // bst1.InsertIterative(next);
    bst2.InsertRecursive(i);
    
    // Console.WriteLine(bst1.FindIterative(next));
}

var x = bst2.DepthFirstSearchPreOrder();
var y = 5;
