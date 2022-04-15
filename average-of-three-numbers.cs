using System;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Title = "Title here";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter first number:");
            double int01 = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("Enter second number:");
            double int02 = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("Enter third number:");
            double int03 = Convert.ToDouble( Console.ReadLine() );
            
            // Get sum of these three numbers
            double sum = int01 + int02 + int03;
            
            // Get average of these three numbers
            double average = sum / 3;

            Console.WriteLine("Average of these three numbers is " + average );

            // Console.ReadKey();
        }
    }
}
