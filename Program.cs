using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();

            // Sum();

            // Subtraction();
            
           // Division();

           // Multiplication();

        }

        static void Menu(){
            
            var check = 1;

            while(Convert.ToBoolean(check) == true){
                
                comeback:

                Console.Clear();

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Sum");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplication");

                Console.WriteLine("-------------------------");
                Console.WriteLine("Select an option: "); 

                var res = short.Parse(Console.ReadLine());

                  switch(res){
                    case 1: Sum(); break;
                    case 2: Subtraction(); break;
                    case 3: Division(); break;
                    case 4: Multiplication(); break;

                    default: Console.WriteLine("Not found");
                    break;
                    }
                    
                if (!(res == 1) && !(res == 2) && !(res == 3) && !(res == 4))
                {
                    goto comeback;
                }

                comeback2:

                Console.WriteLine("Would you like to do it again?(S/N)");

                var res2 = Console.ReadLine();

                if(res2 == "S"){
                    
                    goto comeback;
                }
                else if(!(res2 == "S") && !(res2 == "N")){

                    Console.WriteLine("Not found");
                    goto comeback2;
                }else{
                    check = 0;
                }
            }
            Console.WriteLine("End!");

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

        static void Multiplication(){
            Console.Clear();

            Console.WriteLine("Type the first value: ");

            var num1 = Console.ReadLine();

            Console.WriteLine("Type the second value: ");

            var num2 = Console.ReadLine();

            var result = double.Parse(num1) * double.Parse(num2);

            Console.WriteLine($"The result of the multiplication is {result}");

            Console.ReadKey();
        }

    }


}
