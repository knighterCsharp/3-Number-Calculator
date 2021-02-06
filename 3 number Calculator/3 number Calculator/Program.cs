using System;

namespace _3_number_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0; int num3 = 0;
            Console.WriteLine("Welcome to Three Number Calculator! Please be coherent while choosing numbers. Thanks\r");
            Console.WriteLine("+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+-/*+\n");

            Console.WriteLine("Please type your first number to be calculated, then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type your second number to be calculated, then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type your last number to be calculated, then press Enter");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Choose a type of operation to be used on your purpose");
            Console.WriteLine("\tA - Addition");
            Console.WriteLine("\tS - Subtraction");
            Console.WriteLine("\tM - Multiplication");
            Console.WriteLine("\tD - Dividing");
            Console.Write("Write it: ");

            switch (Console.ReadLine())
            {
                case "A":
                    Console.WriteLine($"Your result: {num1} + {num2} + {num3} = " + (num1 + num2 + num3));
                    break;
                case "S":
                    Console.WriteLine($"Your result: {num1} - {num2} - {num3} = " + (num1 - num2 + num3));
                    break;
                case "M":
                    Console.WriteLine($"Your result: {num1} * {num2} * {num3} = " + (num1 * num2 * num3));
                    break;
                case "D":
                    Console.WriteLine($"Your result: {num1} / {num2} / {num3} = " + (num1 / num2 / num3));
                    break;
            }
            Console.Write("Thanks for using our simple app, Press any key to close the calculator");
            Console.ReadKey();
        }
    }
}
