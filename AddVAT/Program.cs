using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(x =>
            {
                return x + (x * 0.20);
            }).ToArray();

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"{prices[i]:f2}");
            }
        }
    }
}
