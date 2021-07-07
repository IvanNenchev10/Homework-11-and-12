using System;
using System.Collections.Generic;
namespace Exceptions
{
    class Program
    {
        class EvenNumberException:Exception
        {
            public EvenNumberException(string message) : base(message) { }
        }
        static int Sum(int number1,int number2)
        {
            return number1 + number2;
        }
        static void Main()
        {
            int a, b;
            try
            {
                Console.WriteLine("Enter first number:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = int.Parse(Console.ReadLine());
                if(a==b)
                {
                    throw new EvenNumberException("number1 can not be equal to number2");
                }
                if(a<0 || b<0)
                {
                    throw new ArithmeticException("number 1 and number 2 should be positive");
                }
                Console.WriteLine("{0}+{1}={2}", a, b, Sum(a, b));
            }
            catch(EvenNumberException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            catch(FormatException )
            {
                Console.WriteLine("Number is in incorrect format");
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }
    }
}
