using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            numbers = numbers.Where(number => number % 2 == 0).ToList();
            numbers = numbers.OrderBy(number => number).ToList();


            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
