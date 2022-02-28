``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.102
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|      Method |                  Mean |              Error |             StdDev | Rank |  Gen 0 | Allocated |
|------------ |----------------------:|-------------------:|-------------------:|-----:|-------:|----------:|
|        Tab5 |              9.440 ns |          0.0972 ns |          0.0861 ns |    1 | 0.0172 |      72 B |
|  Recursive5 |             15.317 ns |          0.2479 ns |          0.2319 ns |    2 |      - |         - |
|       Tab10 |             17.062 ns |          0.3041 ns |          0.2844 ns |    3 | 0.0268 |     112 B |
|       Memo5 |             19.458 ns |          0.4183 ns |          0.4475 ns |    4 | 0.0115 |      48 B |
|      Memo10 |             46.257 ns |          0.8317 ns |          0.6945 ns |    5 | 0.0172 |      72 B |
|       Tab50 |             73.598 ns |          0.4597 ns |          0.4075 ns |    6 | 0.0975 |     408 B |
|   MemoDict5 |             80.782 ns |          1.1259 ns |          1.4239 ns |    7 | 0.0459 |     192 B |
| Recursive10 |            205.631 ns |          3.8688 ns |          5.6708 ns |    8 |      - |         - |
|      Memo50 |            255.610 ns |          3.6441 ns |          3.4087 ns |    9 | 0.0515 |     216 B |
|  MemoDict10 |            298.972 ns |          5.8991 ns |          8.8296 ns |   10 | 0.1855 |     776 B |
|  MemoDict50 |          1,446.301 ns |         12.1218 ns |         10.7456 ns |   11 | 0.8125 |   3,400 B |
| Recursive50 | 11,082,334,138.462 ns | 96,001,085.9121 ns | 80,165,254.6478 ns |   12 |      - |   1,088 B |
