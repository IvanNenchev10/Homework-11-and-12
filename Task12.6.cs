using System;
using System.Collections.Generic;

namespace Task125
{
    class Program
    {
        static int Length()
        {
            int n;
            Console.WriteLine("Enter string Length:");
            n = int.Parse(Console.ReadLine());
            return n;
        }
        static string[] CreateSentence()
        {
            string[] sentence = new string[Length()];
            for(int i=0;i<sentence.Length;i++)
            {
                Console.WriteLine("Enter word:");
                sentence[i] = Console.ReadLine();
            }
            return sentence;
        }
        static void PrintSentence(string[] sentence)
        {
            for(int i=0;i<sentence.Length;i++)
            {
                Console.Write("{0} ", sentence[i]);
            }
        }
        static void ReverseSentence(Stack<string> stack)
        {
            while(stack.Count!=0)
            {
                Console.Write("{0} ", stack.Peek());
                stack.Pop();
            }
        }
        static void Main()
        {
            string[] sentence = CreateSentence();
            Stack<string> stack = new Stack<string>(sentence);
            PrintSentence(sentence);
            Console.WriteLine();
            ReverseSentence(stack);
        }
    }
}
