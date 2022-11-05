using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());

            float kilometers = meter / 1000.0f;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
