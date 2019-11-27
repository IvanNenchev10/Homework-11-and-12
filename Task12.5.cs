using System;
using System.Collections.Generic;

namespace Task124
{
    class Program
    {
        static void FillQueue(Queue<int> q)
        {
            for(int i=1;i<=10;i++)
            {
                q.Enqueue(i);
            }
        }
        static void PrintQueue(Queue<int> q)
        {
            while(q.Count!=0)
            {
                if(q.Peek()==5)
                {
                    Console.WriteLine("Number 5 is reached");
                    break;
                }
                else
                {
                    Console.WriteLine("{0}", q.Peek());
                    q.Dequeue();
                }
            }
        }
        static void Main()
        {
            Queue<int> q = new Queue<int>();
            FillQueue(q);
            PrintQueue(q);
        }
    }
}
