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
            var intList = new List<string>();
            var box=new Box<string>();
            for (int i = 0; i < n; i++)
            {
                var input = (Console.ReadLine());
                intList.Add(input);
            }

            var element = (Console.ReadLine());
         
            Console.WriteLine(box.CompareElements(intList, element));

        }
    }
}
