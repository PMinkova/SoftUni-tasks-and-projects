using System;
using System.Collections;
using System.Collections.Generic;

namespace P03_Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
            this.stack = new List<T>();
        }
        public void Push(T element)
        {
            this.stack.Add(element);
        }

        public void Pop()
        {
            if (this.stack.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.stack.RemoveAt(this.stack.Count - 1);
            }
        }

        public void PrintAllElements(Stack<string> stack)
        {
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
