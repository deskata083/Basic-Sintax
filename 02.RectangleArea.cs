
namespace RectangleArea
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());

            double area = width * lenght;

            Console.WriteLine($"{area:F2}");

        }
    }
}
