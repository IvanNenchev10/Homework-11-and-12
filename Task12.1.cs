using System;
using System.Collections.Generic;


namespace Homework12
{
    class Program
    {
        static void FillList(List<int> list)
        {
            for(int i=1;i<=100;i++)
            {
                list.Add(i);
            }
        }
        static void PrintList(List<int> list)
        {
            foreach(int i in list)
            {
                Console.Write("{0} ", i);
            }
        }
        static void RemoveFromList(List<int> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i]%10==0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        static void Main()
        {
            List<int> list = new List<int>();
            FillList(list);
            PrintList(list);
            Console.WriteLine();
            RemoveFromList(list);
            PrintList(list);
        }
    }
}
