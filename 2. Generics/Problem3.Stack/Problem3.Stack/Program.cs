using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<int>();
            Stack<int> stack=new Stack<int>(collection);
            var input = Console.ReadLine();
            while (input != "END")
            {
                var commandArgs = input
                    .Split(' ')
                    .ToList();
                var command = commandArgs[0];
               collection = input.Split(new []{',',' '}, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToList();
                    switch (command)
                {
                    case "Push":
                        stack.Push(collection);
                        break;
                    case "Pop":
                        if(stack.Pop()!=string.Empty)
                            Console.WriteLine(stack.Pop());
                        break;
                    default: break;
                }
                input = Console.ReadLine();
            }
            if (stack.Count()!=0)
            {
                Console.WriteLine(stack);

            }

        }
    }
}
