﻿using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
