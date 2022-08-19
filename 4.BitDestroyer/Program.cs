using System;

namespace BitDestroyer
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
            string sum = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                char currNumber = result[i];
                if (i == p)
                {
                    currNumber = (char)48;
                }
                sum += currNumber;
            }
            string stringToInt = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                if ((char)sum[i] == 48)
                {
                    stringToInt += 0;
                }
                else
                {
                    stringToInt += 1;
                }
            }
            long binaryToInt = long.Parse(stringToInt);
            long resultInt = binaryToInt;
            double sumNumber = 0;
            long resultNum = 0;
            int digitsCount = 0;
            while (resultInt > 0)
            {
                resultNum = resultInt % 10;
                sumNumber += resultNum * Math.Pow(2, digitsCount);
                digitsCount++;
                resultInt = resultInt / 10;
            }
            Console.WriteLine(sumNumber);
        }
    }
}
