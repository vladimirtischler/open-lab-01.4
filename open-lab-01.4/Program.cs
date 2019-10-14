using System;

namespace ConsoleApp1
{
    class Program
    {
        public static double AreaTriangel(double a, double b)
        {
            return (a * b / 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the SiteA for triangle");
            double SiteA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Weight for triangle");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area is {AreaTriangel(SiteA, weight)}");







        }
    }
}
