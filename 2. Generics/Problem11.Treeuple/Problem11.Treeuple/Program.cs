using System;

namespace Problem11.Treeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstData = Console.ReadLine()
                .Split(' ');
            var name = inputFirstData[0] + " " + inputFirstData[1];
            var addres = inputFirstData[2];
            var town = inputFirstData[3];
            Treeuple<string, string,string> treeupple1 = new Treeuple<string, string,string>(name, addres,town);
            Console.WriteLine(treeupple1);
            var inputSecondData = Console.ReadLine()
                .Split(' ');
            var firstItem = inputSecondData[0];
            var secondItem = int.Parse(inputSecondData[1]);
            var thirdItem = "False";
            if (inputSecondData[2] == "drunk")
            {
                thirdItem = "True";
            }
           Treeuple<string, int,string> treeuple2= new Treeuple<string, int,string>(firstItem, secondItem,thirdItem);
            Console.WriteLine(treeuple2);
            var inputThirdData = Console.ReadLine()
                .Split(' ');
            var firstItem3 = (inputThirdData[0]);
            var secondItem3 = double.Parse(inputThirdData[1]);
            var thirdItem3 = inputThirdData[2];
            Treeuple<string, double,string> treeuple3 = new Treeuple<string, double,string>(firstItem3, secondItem3,thirdItem3);
            Console.WriteLine(treeuple3);
        }
    }
}
