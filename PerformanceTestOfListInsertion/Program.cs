namespace PerformanceTestOfListInsertion
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Tests>(
                DefaultConfig.Instance.With(
                    new Job()
                        .WithLaunchCount(2)
                        .WithWarmupCount(5)
                        .WithIterationCount(10)
                ));
        }
    }
}
