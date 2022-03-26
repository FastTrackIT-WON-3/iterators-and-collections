using System.Collections.Generic;

namespace IteratorsAndCollections
{
    public static class Fibonacci
    {
        public static IEnumerable<long> Generate(int n)
        {
            if (n < 0)
            {
                yield break;
            }

            if (n >= 0)
            {
                yield return 0;
            }

            if (n >= 1)
            {
                yield return 1;
            }

            if (n >= 2)
            {
                long fibo_2 = 0;
                long fibo_1 = 1;

                for (int i = 2; i <= n; i++)
                {
                    long fibo = fibo_1 + fibo_2;
                    yield return fibo;

                    fibo_2 = fibo_1;
                    fibo_1 = fibo;
                }
            }
        }
    }
}
