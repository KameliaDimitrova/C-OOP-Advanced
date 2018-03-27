using System;
using System.Collections.Generic;

namespace Problem_10.__Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
             var inputFirstData = Console.ReadLine()
                .Split(' ');
            var name = inputFirstData[0] +" "+ inputFirstData[1];
            var addres = inputFirstData[2];
            Tuple<string,string> tupple1=new Tuple<string, string>(name,addres);
            Console.WriteLine(tupple1);
            var inputSecondData = Console.ReadLine()
                .Split(' ');
            var firstItem = inputSecondData[0];
            var secondItem = int.Parse(inputSecondData[1]);
            Tuple<string, int> tupple2 = new Tuple<string, int>(firstItem, secondItem);
            Console.WriteLine(tupple2);
            var inputThirdData = Console.ReadLine()
                .Split(' ');
            var firstItem3 = int.Parse(inputThirdData[0]);
            var secondItem3 = double.Parse(inputThirdData[1]);
            Tuple<int, double> tupple3 = new Tuple<int, double>(firstItem3, secondItem3);
            Console.WriteLine(tupple3);

        }
    }
}
