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
            var intList = new List<double>();
            var box=new Box<double>();
            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                intList.Add(input);
            }

            var element = double.Parse(Console.ReadLine());
         
            Console.WriteLine(box.CompareElements(intList, element));

        }
    }
}
