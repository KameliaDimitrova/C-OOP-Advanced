using System;
using System.Linq;

namespace Problem4.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            Lake<int> lake=new Lake<int>(input);
            Console.WriteLine(string.Join(", ", lake));

        }
    }
}
