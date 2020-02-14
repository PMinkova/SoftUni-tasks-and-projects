using System;
using System.Collections.Generic;

namespace P05_GenericCountMethodStrings
{
    public class Box<T> where T: IComparable
    {
        public Box()
        {
            this.Values = new List<T>();
        }
        public List<T> Values { get; set; }

        public void Swap(int first, int second)
        {
            bool isInRange = first >= 0 && first < this.Values.Count &&
                             second >= 0 && second < this.Values.Count;

            if (!isInRange)
            {
                throw new InvalidOperationException("Values are not in range!");
            }

            var tempValue = Values[first];

            Values[first] = Values[second];
            Values[second] = tempValue;
        }

        public int CountElementsGraterThanValue(T element)
        {
            var counter = 0;

            foreach (var el in this.Values)
            {
                if (el.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
