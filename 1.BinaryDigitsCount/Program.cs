using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int digit = number;
            string result = "";
            int num = 0;
            if (B == 1)
            {
                num = 49;
            }
            else
            {
                num = 48;
            }
            while (digit > 0)
            {
                result += digit % 2;
                digit = digit / 2;
            }
            int resultCount = 0;
            for (int i = 0; i < result.Length; i++)
            {
                char currNumber = result[i];
                if (currNumber == num)
                {
                    resultCount++;
                }
            }
            Console.WriteLine(resultCount);
        }
    }
}
