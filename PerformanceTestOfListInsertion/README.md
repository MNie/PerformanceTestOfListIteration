I often see in pull request a mutation of a list. I always said that this is not a good idea but these are only my words maybe with some articles to prove my rights. 
This is why I decided to create some benchmarks to show that Mutation is not a good idea. Below you could find results from the benchmarks.

``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.112 (1803/April2018Update/Redstone4)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT  [AttachedDebugger]
  Job-HVYYGX : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT

IterationCount=10  LaunchCount=2  WarmupCount=5  

```
|                       Method |        Mean |      Error |     StdDev |    Gen 0 |   Gen 1 |   Gen 2 |  Allocated |
|----------------------------- |------------:|-----------:|-----------:|---------:|--------:|--------:|-----------:|
|        WithMutationTestSmall |    26.06 us |  0.2547 us |  0.2831 us |   3.9978 |       - |       - |    12.3 KB |
|       WithMutationTestMedium |   256.99 us |  5.3920 us |  6.2094 us |  37.5977 |       - |       - |  117.78 KB |
|          WithMutationTestBig | 3,553.16 us | 47.0130 us | 52.2549 us | 210.9375 | 97.6563 | 39.0625 | 1272.02 KB |
|  WithPredefinedSizeTestSmall |    24.65 us |  0.2059 us |  0.2289 us |   3.5400 |       - |       - |   10.96 KB |
| WithPredefinedSizeTestMedium |   247.12 us |  1.6088 us |  1.8527 us |  35.1563 |       - |       - |   109.4 KB |
|    WithPredefinedSizeTestBig | 2,608.53 us | 31.7756 us | 35.3185 us | 191.4063 | 93.7500 |       - | 1093.77 KB |
|  WithLazyEvaluationTestSmall |    27.37 us |  0.1751 us |  0.2017 us |   4.0283 |       - |       - |   12.41 KB |
| WithLazyEvaluationTestMedium |   277.71 us |  7.9785 us |  9.1881 us |  38.0859 |  0.4883 |       - |  117.89 KB |
|    WithLazyEvaluationTestBig | 3,718.37 us | 22.2728 us | 23.8316 us | 210.9375 | 97.6563 | 39.0625 |  1272.1 KB |
|          WithSelectTestSmall |    24.45 us |  0.0937 us |  0.0963 us |   3.6011 |       - |       - |   11.07 KB |
|    WithSelectTestMediumSmall |   246.86 us |  2.6934 us |  3.1017 us |  35.1563 |       - |       - |  109.51 KB |
|            WithSelectTestBig | 2,570.04 us | 19.1668 us | 22.0725 us | 191.4063 | 93.7500 |       - | 1093.88 KB |
