using System;

namespace BitatPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number;
            string result = "";
            while (digit > 0)
            {
                result += digit % 2;
                digit = digit / 2;
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                char currNumber = result[i];
                if (i == 1)
                {
                    Console.WriteLine(currNumber);
                }
            }
        }
    }
}
