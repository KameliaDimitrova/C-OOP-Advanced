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
            var stringList = new List<string>();
            var box=new Box<string>();
            for (int i = 0; i < n; i++)
            {
                var input = (Console.ReadLine());
                stringList.Add(input);
            }
            var indexes = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var firstIndex = int.Parse(indexes[0]);
            var secondIndex = int.Parse(indexes[1]);

            Console.WriteLine(box.SwapTwoElements(stringList, firstIndex, secondIndex));

        }
    }
}
