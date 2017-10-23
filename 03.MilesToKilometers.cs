
namespace MilesToKilometers
{
    using System;
    public class StartUp
    {
       public static void Main(string[] args)
        {
            double miles = Double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
