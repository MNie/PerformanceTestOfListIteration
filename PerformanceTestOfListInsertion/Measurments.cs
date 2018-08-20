namespace PerformanceTestOfListInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Measurments
    {
        public static IReadOnlyCollection<string> WithMutation(IList<int> list)
        {
            var l = new List<string>();
            for(int i = 0; i < list.Count; ++i)
                l.Add(GenerateElement());
            return l;
        }

        public static IReadOnlyCollection<string> WithPredefinedSize(IList<int> list)
        {
            var l = new string[list.Count];
            for (int i = 0; i < list.Count; ++i)
                l[i] = GenerateElement();
            return l;
        }

        public static IReadOnlyCollection<string> WithLazyEvaluation(IList<int> list)
        {
            IEnumerable<string> Select()
            {
                foreach (var _ in list)
                    yield return GenerateElement();
            }

            return Select().ToList();
        }

        public static IReadOnlyCollection<string> WithSelect(IList<int> list) => 
            list.Select(_ => GenerateElement()).ToList();

        private static string GenerateElement() =>
            Guid.NewGuid().ToString();
    }
}