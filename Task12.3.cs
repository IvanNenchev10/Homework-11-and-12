using System;
using System.Collections.Generic;

namespace ConsoleApplication122
{
    class Program
    {
        class Bike
        {
            private string brand;
            private string model;
            private string colour;
            public Bike()
            {
                brand = null;
                model = null;
                colour = null;
            }
            public Bike(string brand,string model,string colour)
            {
                this.brand = brand;
                this.model = model;
                this.colour = colour;
            }
            public string Brand
            {
                set { brand = value;}
                get { return brand;}
            }
            public string Model
            {
                set { model = value;}
                get { return model;}
            }
            public string Colour
            {
                set { colour = value;}
                get { return colour;}
            }
        }
        static Bike CreateBike()
        {
            string brand, model, colour;
            Console.WriteLine("Enter brand:");
            brand = Console.ReadLine();
            Console.WriteLine("Enter model:");
            model = Console.ReadLine();
            Console.WriteLine("Enter colour:");
            colour = Console.ReadLine();
            Bike bike = new Bike(brand, model, colour);
            return bike;
        }
        static void FillLinkedList(LinkedList<Bike> list)
        {
            list.AddLast(CreateBike());
        }
        static void PrintLinkedList(LinkedList<Bike> list)
        {
           foreach(Bike bike in list)
            {
                Console.WriteLine("Brand:{0}", bike.Brand);
                Console.WriteLine("Model:{0}", bike.Model);
                Console.WriteLine("Colour:{0}", bike.Colour);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            LinkedList<Bike> list = new LinkedList<Bike>();
            int n;
            Console.WriteLine("Enter number of bikes:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                FillLinkedList(list);
                n--;
            }
            PrintLinkedList(list);
        }
    }
}
