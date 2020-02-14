
using System;
using System.Text;

namespace P07_Tuple
{
    public class Tuple<T1, T2>
    {
        public Tuple(T1 element1, T2 element2)
        {
            this.Item1 = element1;
            this.Item2 = element2;
        }
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
