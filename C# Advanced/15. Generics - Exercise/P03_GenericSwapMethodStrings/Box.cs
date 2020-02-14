using System;
using System.Collections.Generic;
using System.Text;

namespace P03_GenericSwapMethodStrings
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
            bool isOutOfRange = first < 0 || first >= this.Values.Count ||
                                second < 0 || second >= this.Values.Count;

            if (isOutOfRange)
            {
                throw new InvalidOperationException("Values are not in range!");
            }

            var tempValue = Values[0];

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
