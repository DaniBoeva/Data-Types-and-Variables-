using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int sumDigitsNum = 0;
                int currentNum = i;

                while (currentNum > 0)
                {
                    sumDigitsNum +=  currentNum % 10;
                    currentNum /= 10;
                }

                if (sumDigitsNum == 5 || sumDigitsNum == 7 || sumDigitsNum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
