using System.Collections.Generic;
public class AgePersonComparator:IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        if (firstPerson.Age < secondPerson.Age)
        {
            return -1;
        }
        return 1;
    }
}

