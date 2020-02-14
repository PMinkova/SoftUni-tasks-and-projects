using System;
using System.Collections.Generic;
using System.Text;

namespace P04_GenericSwapMethodIntegers
{
    public class Box<T>
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
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
