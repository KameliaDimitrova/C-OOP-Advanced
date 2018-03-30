using System.Collections;
using System.Collections.Generic;


public  class ListyIterator<T>:IEnumerable<T>
{
    private readonly List<T> collection;
    private int index;

    public ListyIterator(List<T> collection)
    {
        this.collection = collection;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.collection.Count; i++)
        {
            yield return this.collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Move()
    {
        if (index++ < collection.Count)
        {
            return true;
        }
        return false;
    }

    public string  Print()
    {
        if (this.collection.Count == 0)
            return "Invalid Operation!";
        return collection[index].ToString();
    }

    public string PrintAll()
    {
        return string.Join(' ', this.collection);
    }

    public bool HasNext()
    {
        var currIndex = this.index+1;
        if (currIndex < collection.Count)
        {
            return true;
        }
        return false;
    }
}
