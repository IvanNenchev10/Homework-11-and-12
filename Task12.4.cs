using System;
using System.Collections.Generic;

namespace Task123
{
    class Program
    {
        static void FillStack(Stack<int> stack)
        {
            int k = 1;
            while(k<=50)
            {
                stack.Push(k);
                k++;
            }
        }
        static void PrintStack(Stack<int> stack)
        {
            while(stack.Count!=0)
            {
                Console.Write("{0} , ", stack.Peek());
                stack.Pop();
            }
        }
        static void FillList(List<int> list)
        {
           for(int i=1;i<=50;i++)
            {
                list.Add(i);
            }
        }
        static void PrintList(List<int> list)
        {
           for(int i=0;i<list.Count;i++)
            {
                Console.Write("{0} , ", list[i]);
            }
        }
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();
            FillStack(stack);
            PrintStack(stack);
            Console.WriteLine();
            FillList(list);
            list.Reverse();
            PrintList(list);
            
        }
    }
}
