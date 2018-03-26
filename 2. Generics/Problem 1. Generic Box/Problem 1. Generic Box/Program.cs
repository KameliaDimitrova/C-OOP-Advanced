using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Generic_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var intList = new List<int>();
            var box=new Box<int>();
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                intList.Add(input);
            }
            var indexes = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var firstIndex = int.Parse(indexes[0]);
            var secondIndex = int.Parse(indexes[1]);

            Console.WriteLine(box.SwapTwoElements(intList, firstIndex, secondIndex));

        }
    }
}
