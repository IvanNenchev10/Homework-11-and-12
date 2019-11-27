using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        class Stack
        {
            private int[] arr;
            private int size;
            private int capacity;
            public Stack()
            {
                arr = null;
                size = 0;
                capacity = 0;
            }
            public Stack(int[] array,int size)
            {
                this.size = size;
                capacity = size * 2;
                arr = new int[capacity];
                for(int i=0;i<size;i++)
                {
                    arr[i] = array[i];
                }
            }
            public void Resize()
            {
                int[] array = new int[capacity];
                array = arr;
                arr = new int[capacity * 2];
                for(int i=0;i<capacity;i++)
                {
                    arr[i] = array[i];
                }
                capacity = capacity * 2;
            }
            public bool Contains(int number)
            {
                bool result = false;
                for(int i=0;i<size;i++)
                {
                    if(arr[i]==number)
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }
            public int Peek()
            {
                return arr[0];
            }
            public int Count()
            {
                return size;
            }
            public void Push(int number)
            {
                if (size >= capacity)
                {
                    Resize();
                    for(int i=size;i>0;i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[0] = number;
                    size++;
                }
                else
                {
                    for (int i = size; i > 0; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[0] = number;
                    size++;
                }
            }
            public void Pop()
            {
                size--;
                for(int i=0;i<size;i++)
                {
                    arr[i] = arr[i + 1];
                }
            }
            public void Clear()
            {
                arr = null;
            }
            public void Print()
            {
               for(int i=0;i<size;i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }
        static void CreateArray(int[] arr)
        {
           for(int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine("Enter element:");
                arr[i] = int.Parse(Console.ReadLine());
            } 
        }
        static void Push(Stack stack1)
        {
            int number;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            stack1.Push(number);
        }
        static void Pop(Stack stack1)
        {
            stack1.Pop();
        }
        static void Contain(Stack stack1)
        {
            int number;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            if(stack1.Contains(number)==true)
            {
                Console.WriteLine("Stack contains number {0}", number);
            }
            else
            {
                Console.WriteLine("Stack does contain number {0}", number);
            }
        }
        static void Count(Stack stack1)
        {
            Console.WriteLine("Stack contains {0} elements", stack1.Count());
        }
        static void Peek(Stack stack1)
        {
            Console.WriteLine("Peek element:{0}", stack1.Peek());
        }
        static void Print(Stack stack1)
        {
            stack1.Print();
        }
        static void Clear(Stack stack1)
        {
            Console.WriteLine("Stack is successfully deleted");
            stack1.Clear();
        }
        static void Main()
        {
            int n;
            int[] arr;
            Console.WriteLine("Enter number of elements:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            CreateArray(arr);
            Stack stack1 = new Stack(arr, n);
            Print(stack1);
            Push(stack1);
            Push(stack1);
            Push(stack1);
            Console.WriteLine();
            Print(stack1);
            Console.WriteLine();
            Pop(stack1);
            Console.WriteLine();
            Print(stack1);
            Console.WriteLine();
            Count(stack1);
            Console.WriteLine();
            Contain(stack1);
            Console.WriteLine();
            Peek(stack1);
            Console.WriteLine();
            try
            {
                Clear(stack1);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Stack is empty");
            }
            
            
        }
    }
}
