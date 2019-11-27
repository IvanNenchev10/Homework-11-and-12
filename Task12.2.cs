using System;
using System.Collections.Generic;

namespace Task121
{
    class Program
    {
        class Car
        {
            private string brand;
            private string model;
            private int seatsNumber;
            private int registerNumber;
            public Car()
            {
                brand = null;
                model = null;
                seatsNumber = 0;
                registerNumber = 0;
            }
            public Car(string brand,string model,int seatsNumber,int registerNumber)
            {
                this.brand = brand;
                this.model = model;
                this.seatsNumber = seatsNumber;
                this.registerNumber = registerNumber;
            }
            public string Brand
            {
                set { brand = value; }
                get { return brand; }
            }
            public string Model
            {
                set { model = value; }
                get { return model; }
            }
            public int SeatsNumber
            {
                set { seatsNumber = value; }
                get { return seatsNumber; }
            }
            public int RegisterNumber
            {
                set { registerNumber = value; }
                get { return registerNumber; }
            }
        }
        static Car CreateCar()
        {
            string brand, model;
            int registerNumber, seatsNumber;
            Console.WriteLine("Enter brand:");
            brand = Console.ReadLine();
            Console.WriteLine("Enter model:");
            model = Console.ReadLine();
            Console.WriteLine("Enter register number:");
            registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of seats:");
            seatsNumber = int.Parse(Console.ReadLine());
            Car car = new Car(brand, model, seatsNumber, registerNumber);
            return car;
            
        }
        static void CreateList(List<Car> cars)
        {
            cars.Add(CreateCar());
        }
        static void PrintList(List<Car> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine("Car {0}", i + 1);
                Console.WriteLine("{0}", list[i].Brand);
                Console.WriteLine("{0}", list[i].Model);
                Console.WriteLine("{0}", list[i].SeatsNumber);
                Console.WriteLine("{0}", list[i].RegisterNumber);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int n;
            Console.WriteLine("Enter number of cars:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                CreateList(cars);
                n--;
            }
            PrintList(cars);

            
        }
    }
}
