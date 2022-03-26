using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndCollections
{
    public class EvenNumbersEnumeration : IEnumerable<long>
    {
        private readonly IEnumerable<long> _source;
        
        public EvenNumbersEnumeration(IEnumerable<long> source)
        {
            _source = source ?? Enumerable.Empty<long>();
        }

        public IEnumerator<long> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        private IEnumerator<long> GetEnumeratorInternal()
        {
            foreach (long number in _source)
            {
                Console.WriteLine($"EvenNumbersEnumeration: {number}");
                bool isEven = number % 2 == 0;
                if (isEven)
                {
                    yield return number;
                }
            }
        }
    }
}
