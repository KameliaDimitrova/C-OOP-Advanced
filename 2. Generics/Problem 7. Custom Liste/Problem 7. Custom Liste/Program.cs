using System;

namespace Problem_7._Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customList=new CustomList<string>();
            var input = Console.ReadLine();
            while(input!="END")
            {
                var commandArgs = input.Split(' ');
                var command = commandArgs[0];
                string element;
                switch (command)
                {
                    case "Add":
                        element = commandArgs[1];
                        customList.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(commandArgs[1]);
                        Console.WriteLine(customList.Remove(index));
                        break;
                    case "Contains":
                        element = commandArgs[1];
                        Console.WriteLine(customList.Contains(element));
                        break;
                    case "Swap":
                        var index1 = int.Parse(commandArgs[1]);
                        var index2 = int.Parse(commandArgs[2]);
                        customList.Swap(index1,index2);
                        break;
                    case "Greater":
                        element = commandArgs[1];
                        Console.WriteLine(customList.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(customList.ToString());
                        break;
                        default: break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
