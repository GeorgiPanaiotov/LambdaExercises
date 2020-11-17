using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int sum = 0;
            int nums = 0;
            nums = numbers.Length;
            sum = numbers.Sum();

            Console.WriteLine(nums);
            Console.WriteLine(sum);
        }
    }
}
