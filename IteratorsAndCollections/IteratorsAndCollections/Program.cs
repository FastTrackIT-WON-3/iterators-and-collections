using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<long> evenNumbersCollection = new EvenNumbersEnumeration(InfiniteLoopGenerator.Generate());
            foreach (int element in evenNumbersCollection)
            {
                // break;
                Console.WriteLine(element);
                if (element > 100)
                {
                    break;
                }

            }

            /*
            int n = 100;
            foreach(int element in new EvenNumbersEnumeration(Fibonacci.Generate(n)))
            {
                Console.WriteLine(element);
                if (element > 100)
                {
                    break;
                }
            }
            */
            return;

            // MyCollection<int> collection = new MyCollection<int>(1, 2, 3);
            TupleOfThreeIntegers collection = new TupleOfThreeIntegers(1, 2, 3);
            foreach (int element in collection)
            {
                Console.WriteLine(element);
                Console.WriteLine("----");
            }

            /* equivalent to 
            *********************************************************
            IEnumerator<int> enumerator = collection.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            */
        }
    }
}
