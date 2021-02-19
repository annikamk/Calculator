using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num1 = 0; int num2 = 0;
            Console.WriteLine("****************");
            Console.WriteLine("   Calculator");
            Console.WriteLine("****************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Type a number, and then press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your Option");

            switch (Console.ReadLine())

            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result : {num1} - {num2} =" + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result : {num1} * {num2} =" + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result : {num1} / {num2} =" + (num1 / num2));
                    break;

            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
