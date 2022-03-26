using System;
using System.Collections.Generic;

namespace IteratorsAndCollections
{
    public static class InfiniteLoopGenerator
    {
        public static IEnumerable<long> Generate()
        {
            long start = 0;
            while (true)
            {
                Console.WriteLine($"Infinite generator: {start}");
                yield return start;
                start++;
            }
        }
    }
}
