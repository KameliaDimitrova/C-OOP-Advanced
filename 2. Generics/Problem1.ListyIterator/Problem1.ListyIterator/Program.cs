using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<string>();
            ListyIterator<string> listyIterator=new ListyIterator<string>(collection);
            var input = Console.ReadLine()
                .Split(' ');
            var arguments = input.Skip(1).ToList();
            if (arguments.Count > 0)
            {
                collection = arguments;
                listyIterator = new ListyIterator<string>(collection);
            }
            var command = Console.ReadLine();
            while (command != "END")
            {
                
                switch (command)
                {
                   case "Print":
                        Console.WriteLine(listyIterator.Print());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        Console.WriteLine(listyIterator.PrintAll());
                        break;
                    default: break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
