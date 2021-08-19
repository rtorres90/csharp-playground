using System;
using System.Collections;

namespace using_classes
{
    public class Stack
    {
        private ArrayList arrayList;
        public Stack()
        {
            this.arrayList = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj is not null)
            {
                this.arrayList.Add(obj);
            }
        }
        public object Pop()
        {
            object obj = this.arrayList[0];
            this.arrayList.RemoveAt(0);
            return obj;
        }
        public void PrintStack()
        {
            Console.WriteLine("Stack size: {0}", this.arrayList.Count);
            foreach (object obj in this.arrayList)
            {
                Console.WriteLine("Element: {0}", obj);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("LMAO");
            stack.PrintStack();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.PrintStack();
        }
    }
}
