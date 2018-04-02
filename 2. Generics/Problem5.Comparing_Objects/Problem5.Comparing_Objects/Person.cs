using System;
public  class Person:IComparable<Person>
    {
        public string Name { get;  set; }
        public int Age { get;private set; }
        public string Town { get; private set; }

        public Person(string name, int age,string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            if (this.Name.CompareTo(otherPerson.Name) == 0
            &&this.Age.CompareTo(otherPerson.Age)==0
            &&this.Town.CompareTo(otherPerson.Town)==0)
            {
                return 0;
            }
            return 1;
        }

    }

