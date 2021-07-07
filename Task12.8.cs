using System;
using System.Collections.Generic;
namespace Array
{
    class Program
    {
        class MyList
        {
            private int[] array;
            private int size;
            private int capacity;
            public MyList()
            {
                array = null;
                size = 0;
                capacity = 0;
            }
            public MyList(int[] array,int size)
            {
                this.size = size;
                capacity = size * 2;
                this.array = new int[capacity];
                for(int i=0;i<size;i++)
                {
                    this.array[i] = array[i];
                }
            }
            public void Resize()
            {
                int[] arr = new int[capacity];
                arr = array;
                array = new int[capacity * 2];
                for(int i=0;i<arr.Length;i++)
                {
                    array[i] = arr[i];
                }
                capacity = capacity * 2;
            }
            public void Add(int n)
            {
                if(size>=capacity)
                {
                    Resize();
                    array[size] = n;
                    size++;
                }
                else
                {
                    array[size] = n;
                    size++;
                }
            }
            public void AddRange(int[] array)
            {
                int k = 0;
                if(size>=capacity || (size+array.Length)>=capacity)
                {
                    Resize();
                    for(int i=size;i<(size+array.Length);i++)
                    {
                        this.array[i] = array[k];
                        k++;  
                    }
                   
                }
                else
                {
                   for(int i=size;i<(size+array.Length);i++)
                    {
                        this.array[i] = array[k];
                        k++;
                    }
                }
                size += array.Length;
            }
            public void Insert(int n,int position)
            {
                if(size>=capacity)
                {
                    Resize();
                    for(int i=size;i>position;i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[position] = n;
                    size++;
                }
                else
                {
                    for (int i = size; i > position; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[position] = n;
                    size++;
                }
            }
            public void InsertRange(int[] arr,int position)
            {
                int k = 0;
                if(size>=capacity || size+arr.Length>=capacity)
                {
                    Resize();
                    for(int i=(size+arr.Length);i>position;i--)
                    {
                        array[i] = array[i - arr.Length];
                    }
                    for(int i=position;i<(position+arr.Length);i++)
                    {
                        array[i] = arr[k];
                        k++;
                    }
                }
                else
                {
                    for (int i = (size + arr.Length); i > position; i++)
                    {
                        array[i] = array[i - arr.Length];
                    }
                    for (int i = position; i < (position + arr.Length); i++)
                    {
                        array[i] = arr[k];
                        k++;
                    }
                }
                size += arr.Length;
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
            public void Remove(int number)
            {
               if(Contains(number)==true)
                {
                    for(int i=0;i<size;i++)
                    {
                        if(array[i]==number)
                        {
                            for(int j=i;j<size;j++)
                            {
                                array[j] = array[j + 1];
                            }
                            size--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Element does not exist in the array");
                }
            }
            public void RemoveAt(int position)
            {
                if(position>=size)
                {
                    Console.WriteLine("No such element");
                }
                else
                {
                    for(int i=0;i<size;i++)
                    {
                        if(i==position)
                        {
                            for(int j=position;j<size;j++)
                            {
                                array[j] = array[j + 1];
                            }
                            size--;
                        }
                     }
                }
            }
            public void RemoveRange(int range,int position)
            {
                for(int i=position;i<size;i++)
                {
                    array[i] = array[i + range];
                }
                size -= range;
            }
            public int indexOf(int number)
            {
                int result = -1;
                if(Contains(number)==true)
                {
                    for(int i=0;i<size;i++)
                    {
                        if(array[i]==number)
                        {
                            result = i;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Number does not appear in the array");
                    
                }
                return result;
            }
            public int this[int k]
            {
               get
                {
                    if(k>=0 && k<size)
                    {
                        return array[k];
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index");
                        return -1;
                    }
                }
            }
            public void Reverse()
            {
                for(int i=size-1;i>=0;i--)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            public void Sort()
            {
                int temp;
                for(int i=0;i<size;i++)
                {
                    for(int j=i+1;j<size;j++)
                    {
                        if(array[i]>array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            public void PrintList()
            {
                for(int i=0;i<size;i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                
            }
            public void Clear()
            {
                array = null;
            }
        }
       static void CreateList(int[] arr,int n)
        {
            int number;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter number:");
                number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            
        }
        static void PrintList(MyList list1)
        {
            list1.PrintList();
        }
        static void NewLine()
        {
            Console.WriteLine();
        }
        static void Add(MyList list1)
        {
            int number;
            Console.WriteLine("Enter number in the list:");
            number = int.Parse(Console.ReadLine());
            list1.Add(number);
        }
        static void Insert(MyList list1)
        {
            int number, position;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            position = int.Parse(Console.ReadLine());
            list1.Insert(number, position);
        }
        static void AddRange(MyList list1)
        {
            int[] arr;
            int n;
            Console.WriteLine("Enter size of the array:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter arr[{0}]:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            list1.AddRange(arr);
        }
        static void InsertRange(MyList list1)
        {
            int[] arr;
            int n, position;
            Console.WriteLine("Enter size of the array:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter element [{0}]:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter position:");
            position = int.Parse(Console.ReadLine());
            list1.InsertRange(arr, position);
        }
        static void Remove(MyList list1)
        {
            int number;
            Console.WriteLine("Enter number to remove from the list:");
            number = int.Parse(Console.ReadLine());
            list1.Remove(number);
        }
        static void RemoveAtPosition(MyList list1)
        {
            int position;
            Console.WriteLine("Enter position to delete number:");
            position = int.Parse(Console.ReadLine());
            list1.RemoveAt(position);
        }
        static void RemoveRange(MyList list1)
        {
            int position, range;
            Console.WriteLine("Enter position:");
            position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range:");
            range = int.Parse(Console.ReadLine());
            list1.RemoveRange(range, position);
        }
        static void Contains(MyList list1)
        {
            int number;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (list1.Contains(number) == true)
            {
                Console.WriteLine("Number {0} exists in the list", number);
            }
            else
            {
                Console.WriteLine("Number {0} does not exist in the list", number);
            }
        }
        static void Sort(MyList list1)
        {
            Console.WriteLine("Sorted List:");
            list1.Sort();
        }
        static void Reverse(MyList list1)
        {
            Console.WriteLine("Reversed List:");
            list1.Reverse();
        }
        static void IndexOf(MyList list1)
        {
            int number;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Index of number {0} is:{1}", number, list1.indexOf(number));
        }
        static void Indexer(MyList list1)
        {
            int index;
            Console.WriteLine("Enter index:");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine("Number {0} is at index {1}", list1[index], index);
        }
        static void Clear(MyList list1)
        {
            list1.Clear();
        }
        static void Main()
        {
            int[] arr;
            int n;
            Console.WriteLine("Enter number of elements:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            CreateList(arr, n);
            MyList list1 = new MyList(arr,n);
            PrintList(list1);
            Add(list1);
            NewLine();
            Add(list1);
            NewLine();
            PrintList(list1);
            AddRange(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            Insert(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            InsertRange(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            Remove(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            RemoveAtPosition(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            RemoveRange(list1);
            NewLine();
            PrintList(list1);
            NewLine();
            Contains(list1);
            NewLine();
            Sort(list1);
            PrintList(list1);
            NewLine();
            Reverse(list1);
            NewLine();
            IndexOf(list1);
            NewLine();
            Indexer(list1);
            NewLine();
            Clear(list1);
            try
            {
                PrintList(list1);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("List is empty");
            }
            
        }
    }
}
