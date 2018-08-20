namespace PerformanceTestOfListInsertion
{
    using System.Collections.Generic;
    using System.Linq;

    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class Tests
    {
        private static readonly IList<int> SmallAmount = Enumerable.Range(0, 100).ToList();
        private static readonly IList<int> MediumAmount = Enumerable.Range(0, 1000).ToList();
        private static readonly IList<int> BigAmount = Enumerable.Range(0, 10000).ToList();

        [Benchmark]
        public void WithMutationTestSmall() =>
            Measurments.WithMutation(SmallAmount);

        [Benchmark]
        public void WithMutationTestMedium() =>
            Measurments.WithMutation(MediumAmount);

        [Benchmark]
        public void WithMutationTestBig() =>
            Measurments.WithMutation(BigAmount);

        [Benchmark]
        public void WithPredefinedSizeTestSmall() =>
            Measurments.WithPredefinedSize(SmallAmount);

        [Benchmark]
        public void WithPredefinedSizeTestMedium() =>
            Measurments.WithPredefinedSize(MediumAmount);

        [Benchmark]
        public void WithPredefinedSizeTestBig() =>
            Measurments.WithPredefinedSize(BigAmount);

        [Benchmark]
        public void WithLazyEvaluationTestSmall() =>
            Measurments.WithLazyEvaluation(SmallAmount);

        [Benchmark]
        public void WithLazyEvaluationTestMedium() =>
            Measurments.WithLazyEvaluation(MediumAmount);

        [Benchmark]
        public void WithLazyEvaluationTestBig() =>
            Measurments.WithLazyEvaluation(BigAmount);

        [Benchmark]
        public void WithSelectTestSmall() =>
            Measurments.WithSelect(SmallAmount);

        [Benchmark]
        public void WithSelectTestMediumSmall() =>
            Measurments.WithSelect(MediumAmount);

        [Benchmark]
        public void WithSelectTestBig() =>
            Measurments.WithSelect(BigAmount);
    }
}