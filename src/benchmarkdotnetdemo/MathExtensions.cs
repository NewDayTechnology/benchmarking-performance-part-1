using System.Collections.Generic;
using System.Linq;

namespace benchmarkdotnetdemo
{
    public static class MathExtensions
    {
        public static IEnumerable<int> GetFibonacci(this int count)
        {
            var w = 1;
            var x = 1;

            yield return x;
            foreach (var _ in Enumerable.Range(1, count - 1))
            {
                var y = w + x;
                yield return y;
                w = x;
                x = y;
            }
        }
    }
}
