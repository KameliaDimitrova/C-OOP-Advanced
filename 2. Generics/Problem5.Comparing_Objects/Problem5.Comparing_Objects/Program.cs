using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5.Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            var input = Console.ReadLine();
            var listOfEqualsPersons=new List<int>();
            int position = 1;
            while (input != "END")
            {
                var inputArgs = input
                    .Split(' ')
                    .ToList();
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var town = inputArgs[2];
                var person = new Person(name, age, town);
                persons[position] = person;
                position++;
                input = Console.ReadLine();
            }
            int positionToCompare = int.Parse(Console.ReadLine());
            foreach (var person in persons)
            {
                if (person.Key != positionToCompare)
                {
                    if (persons[positionToCompare].CompareTo(person.Value) == 0)
                    {
                        listOfEqualsPersons.Add(person.Key);
                    }
                }
            }
            if (listOfEqualsPersons.Count > 0)
            {
                Console.WriteLine($"{listOfEqualsPersons.Count+1} {persons.Count-1-listOfEqualsPersons.Count} {persons.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
