using System;
using System.Collections.Generic;

namespace Таск245
{
    class Program
    {
        static void CreateQueue(Queue<string> q)
        {
            string word;
            Console.WriteLine("Enter word:");
            word = Console.ReadLine();
            q.Enqueue(word);
        }
        static bool Length(string word)
        {
            if(word.Length<3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static Queue<string> ChangeQueue(Queue<string> q,Queue<string> q1)
        {
            while(q.Count!=0)
            {
               if(Length(q.Peek())==false)
                {
                    q1.Enqueue(q.Peek());
                }
                q.Dequeue();
            }
            return q1;
        }
        static void Print(Queue<string> q)
        {
            while(q.Count!=0)
            {
                Console.Write("{0} ", q.Peek());
                q.Dequeue();
            }
        }
         static void Main()
        {
            Queue<string> q = new Queue<string>();
            Queue<string> q1 = new Queue<string>();
            int n;
            Console.WriteLine("Queue Length:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                CreateQueue(q);
                n--;
            }
            foreach(string s in q)
            {
                Console.Write("{0} ", s);
            }
            q=ChangeQueue(q,q1);
            Console.WriteLine();
            Print(q1);
           
        }
    }
}
