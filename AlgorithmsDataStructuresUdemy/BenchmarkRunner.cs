using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AlgorithmsDataStructuresUdemy;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BenchmarkRunner
{
    private static readonly DynamicProgramming DynamicProgramming = new DynamicProgramming();
    
    [Benchmark]
    public void Recursive5()
    {
        DynamicProgramming.RecursiveFibonacci(5);
    }

    [Benchmark]
    public void Recursive10()
    {
        DynamicProgramming.RecursiveFibonacci(10);
    }
    
    [Benchmark]
    public void Recursive50()
    {
        DynamicProgramming.RecursiveFibonacci(47);
    }

    [Benchmark]
    public void Memo5()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciArray(5, new int[6]);
    }

    [Benchmark]
    public void Memo10()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciArray(10, new int[11]);
    }
    
    [Benchmark]
    public void Memo50()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciArray(47, new int[48]);
    }
    
    [Benchmark]
    public void MemoDict5()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciDict(5, new Dictionary<int, int>());
    }

    [Benchmark]
    public void MemoDict10()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciDict(10, new Dictionary<int, int>());
    }
    
    [Benchmark]
    public void MemoDict50()
    {
        DynamicProgramming.MemoizedRecursiveFibonacciDict(47, new Dictionary<int, int>());
    }

    [Benchmark]
    public void Tab5()
    {
        DynamicProgramming.TabulatedFibonacciArray(5);
    }
    
    [Benchmark]
    public void Tab10()
    {
        DynamicProgramming.TabulatedFibonacciArray(10);
    }
    
    [Benchmark]
    public void Tab50()
    {
        DynamicProgramming.TabulatedFibonacciArray(47);
    }
}