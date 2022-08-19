using System;
using System.Linq;
namespace OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int num = nums[i] ^ nums[j];
                    Console.WriteLine(num);
                }
            }
        }
    }
}
