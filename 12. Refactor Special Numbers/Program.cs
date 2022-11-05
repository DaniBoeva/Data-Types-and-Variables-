using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                int sumOfDigits = 0;
                int digit = i;
                
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit /= 10;
                }

                if ((sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11))
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
