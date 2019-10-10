using System;

namespace open_lab_01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the triangle.");
            string siteA = Console.ReadLine();
            double a = Convert.ToDouble(siteA);
            Console.WriteLine("Enter the height of the triangle");
            string height = Console.ReadLine();
            double b = Convert.ToDouble(height);
            double c = a * b / 2;
            Console.WriteLine($"The area is {c}!");

        }
    }
}
