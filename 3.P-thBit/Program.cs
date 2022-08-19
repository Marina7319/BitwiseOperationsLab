using System;

namespace PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
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
                if (i == p)
                {
                    Console.WriteLine(currNumber);
                }
            }
            if (result.Length < p && result.Length <= 16)
            {
                Console.WriteLine(0);
            }
        }
    }
}
