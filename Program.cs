using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum();

            // Subtraction();
            
           // Division();

        }

        static void Sum(){
            Console.Clear();
            Console.WriteLine("First value: ");

            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");

            double num2 = double.Parse(Console.ReadLine());

            //First value:
            //5,5
            //Second value: 
            //7,7

            Console.WriteLine("");

            Console.WriteLine($"The result of the values' sum is {num1 + num2}");
            Console.ReadKey();
        }

        static void Subtraction(){
             Console.Clear();
            Console.WriteLine("First value: ");

            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");

            double num2 = double.Parse(Console.ReadLine());

            double result = num1 - num2;

            Console.WriteLine("");

            Console.WriteLine($"The result of the values' subtraction is {result}");
            Console.ReadKey();
        }

        static void Division(){
            Console.Clear();

            Console.WriteLine("First value: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"{num1} devided by {num2} is equal to: {num1 / num2}");

            Console.ReadKey();
        }

    }


}
