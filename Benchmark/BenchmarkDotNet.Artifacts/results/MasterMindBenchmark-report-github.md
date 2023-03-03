``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1265/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.1.23115.2
  [Host]     : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2
  Job-HRPYRA : .NET 8.0.0 (8.0.23.11008), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
|                        Method | SequenceLenght |          Mean |       Error |        StdDev |        Median | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |--------------- |--------------:|------------:|--------------:|--------------:|------:|--------:|----------:|------------:|
|  **SolutionWithDictionaryBenchy** |             **10** |     **13.312 μs** |   **1.5506 μs** |     **4.4240 μs** |     **13.450 μs** |  **1.00** |    **0.00** |         **-** |          **NA** |
| SolutionWithDynamicListBenchy |             10 |      2.568 μs |   0.2700 μs |     0.7705 μs |      2.400 μs |  0.21 |    0.09 |         - |          NA |
|   SolutionWithFixedListBenchy |             10 |      3.014 μs |   0.3300 μs |     0.9627 μs |      2.750 μs |  0.25 |    0.13 |         - |          NA |
|                               |                |               |             |               |               |       |         |           |             |
|  **SolutionWithDictionaryBenchy** |            **100** |     **49.029 μs** |   **3.5245 μs** |    **10.2252 μs** |     **49.050 μs** |  **1.00** |    **0.00** |   **28808 B** |        **1.00** |
| SolutionWithDynamicListBenchy |            100 |     66.559 μs |   2.0963 μs |     5.9468 μs |     65.800 μs |  1.43 |    0.35 |         - |        0.00 |
|   SolutionWithFixedListBenchy |            100 |     22.276 μs |   0.8856 μs |     2.4978 μs |     21.750 μs |  0.48 |    0.14 |         - |        0.00 |
|                               |                |               |             |               |               |       |         |           |             |
|  **SolutionWithDictionaryBenchy** |           **1000** |    **229.326 μs** |   **9.2320 μs** |    **25.5819 μs** |    **222.400 μs** |  **1.00** |    **0.00** |  **202136 B** |        **1.00** |
| SolutionWithDynamicListBenchy |           1000 | 19,208.128 μs | 390.3923 μs | 1,144.9531 μs | 19,115.800 μs | 85.26 |    9.71 |    8824 B |        0.04 |
|   SolutionWithFixedListBenchy |           1000 |    607.701 μs |  19.1813 μs |    54.4140 μs |    598.100 μs |  2.67 |    0.34 |         - |        0.00 |
