using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndCollections
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private readonly T[] array;

        public MyCollection(params T[] elements)
        {
            array = elements ?? new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }

                throw new IndexOutOfRangeException($"Index {index} was outside of the bounds of the array [0, {array.Length - 1}].");
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Console.WriteLine($"Start GetEnumerator");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Before yield return - step={i}");
                yield return array[i];
                Console.WriteLine($"After yield return - step={i}");
            }

            Console.WriteLine($"End GetEnumerator");
            //return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
