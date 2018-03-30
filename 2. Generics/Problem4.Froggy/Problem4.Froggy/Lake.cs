using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lake<T>:IEnumerable<T>
{
    private List<T> collection;

    public Lake(List<T> collection)
    {
        this.collection = new List<T>(collection);
    }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i+=2)
            {
                yield return collection[i];
            }
        for (int i = this.collection.Count - 1; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            yield return this.collection[i];
        }
    }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

}

