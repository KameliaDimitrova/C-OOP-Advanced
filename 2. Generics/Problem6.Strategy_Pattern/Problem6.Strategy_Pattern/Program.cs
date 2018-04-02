using System;
using System.Collections.Generic;

namespace Problem6.Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameSortedSet = new List<Person>();
            var ageSortedSet=new List<Person>();
            var numbersOfinput = int.Parse(Console.ReadLine());
            var agePersonComparator=new AgePersonComparator();
            var namePersonComperator=new NamePersonComparator();
            for (int i = 0; i < numbersOfinput; i++)
            {
                var inputArgs = Console.ReadLine()
                    .Split(' ');
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var person=new Person(name,age);
                nameSortedSet.Add(person);
                ageSortedSet.Add(person);
            }
            nameSortedSet.Sort(namePersonComperator);
            ageSortedSet.Sort(agePersonComparator);
            for (int i = 0; i < nameSortedSet.Count; i++)
            {
                Console.WriteLine(nameSortedSet[i]);
            }
            for (int i = 0; i < ageSortedSet.Count; i++)
            {
                Console.WriteLine(ageSortedSet[i]);
            }
        }
    }
}
