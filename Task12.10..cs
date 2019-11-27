using System;
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        class Queue
        {
            private int[] array;
            private int size;
            private int capacity;
            public Queue()
            {
                array = null;
                size = 0;
                capacity = 0;
            }
            public Queue(int[] arr,int size)
            {
                this.size = size;
                capacity = size * 2;
                array = new int[capacity];
                for(int i=0;i<size;i++)
                {
                    array[i] = arr[i];
                }
            }
            public void Resize()
            {
                int[] arr = new int[capacity];
                arr = array;
                array = new int[capacity * 2];
                for(int i=0;i<capacity;i++)
                {
                    array[i] = arr[i];
                }
                capacity = capacity * 2;
            }
            public void Enqueue(int number)
            {
                if(size>=capacity)
                {
                    Resize();
                    array[size] = number;
                    size++;
                }
                else
                {
                    array[size] = number;
                    size++;
                }
            }
            public void Dequeue()
            {
                size--;
                for(int i=0;i<size;i++)
                {
                    array[i] = array[i + 1];
                }
               
            }
           public bool Contains(int number)
            {
                bool result = false;
                for(int i=0;i<size;i++)
                {
                    if(array[i]==number)
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }
            public int Count()
            {
                return size;
            }
            public int Peek()
            {
                return array[0];
            }
            public void Clear()
            {
                array = null;
            }
            public void Print()
            {
                for(int i=0;i<size;i++)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
        static void CreateQueue(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("Enter element [{0}]:", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }    
        }
        static void Enqueue(Queue q)
        {
            int number;
            Console.WriteLine("Enter number to add:");
            number = int.Parse(Console.ReadLine());
            q.Enqueue(number);
        }
        static void Dequeue(Queue q)
        {
            q.Dequeue();
        }
        static void Contains(Queue q)
        {
            int number;
            Console.WriteLine("Enter number to check:");
            number = int.Parse(Console.ReadLine());
            if(q.Contains(number)==true)
            {
                Console.WriteLine("Number exists in the queue");
            }
            else
            {
                Console.WriteLine("Number does not exist in the queue");
            }
        }
        static void Count(Queue q)
        {
            Console.WriteLine("Number of elements in the queue is:{0}", q.Count());
        }
        static void Peek(Queue q)
        {
            Console.WriteLine("Top element of the queue is:{0}", q.Peek());
        }
        static void Clear(Queue q)
        {
            Console.WriteLine("Queue is successfully deleted");
            q.Clear();
        }
        static void Print(Queue q)
        {
            q.Print();
        }
        static void Main()
        {
            int[] array;
            int n;
            Console.WriteLine("Enter number of elements in the queue:");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            CreateQueue(array);
            Queue q = new Queue(array, n);
            Print(q);
            Console.WriteLine();
            Enqueue(q);
            Enqueue(q);
            Enqueue(q);
            Console.WriteLine();
            q.Print();
            Dequeue(q);
            Console.WriteLine();
            Print(q);
            Console.WriteLine();
            Contains(q);
            Console.WriteLine();
            Count(q);
            Console.WriteLine();
            Peek(q);
            Console.WriteLine();
            try
            {
                Clear(q);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Queue is empty");
            }
        }
    }
}
