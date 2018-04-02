using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

public class NamePersonComparator : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        if (firstPerson.Name.Length == secondPerson.Name.Length)
        {
            if (char.IsLower(firstPerson.Name[0]))
            {
                return -1;
            }
            if (char.IsLower(secondPerson.Name[0]))
            {
                return 1;
            }
            if (firstPerson.Name[0] < secondPerson.Name[0])
                return -1;
            return 1;
        }
        if (firstPerson.Name.Length < secondPerson.Name.Length)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
