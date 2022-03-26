using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    public class TupleOfThreeIntegers : IEnumerable<int>
    {
        public TupleOfThreeIntegers(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int First { get; }

        public int Second { get; }

        public int Third { get; }

        public IEnumerator<int> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        private IEnumerator<int> GetEnumeratorInternal()
        {
            Console.WriteLine("Start - GetEnumeratorInternal ");

            Console.WriteLine("GetEnumeratorInternal - before yield return First");
            yield return First;
            Console.WriteLine("GetEnumeratorInternal - after yield return First");

            Console.WriteLine("GetEnumeratorInternal - before yield return Second");
            yield return Second;
            Console.WriteLine("GetEnumeratorInternal - after yield return Second");

            Console.WriteLine("GetEnumeratorInternal - before yield return Third");
            yield return Third;
            Console.WriteLine("GetEnumeratorInternal - after yield return Third");
        }
    }
}
