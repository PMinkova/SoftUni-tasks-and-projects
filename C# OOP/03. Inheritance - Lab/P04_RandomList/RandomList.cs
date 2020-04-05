using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RemoveRandomElement()
        {
            int index = random.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
