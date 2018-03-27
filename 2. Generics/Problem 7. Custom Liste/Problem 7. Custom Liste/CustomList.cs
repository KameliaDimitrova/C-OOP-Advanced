using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T>
    where T : IComparable
{
    public T[] data { get; set; }
    private int count;
    private int arrMaxSize => this.data.Length;
    public CustomList()
    {
        this.data = new T[5];
    }

    public void Add(T element)
    {
        
        if (count >= arrMaxSize)
        {
            var newData = new T[arrMaxSize * 2];
            Array.Copy(data, newData, arrMaxSize);
            this.data = newData;
        }
        this.data[count] = element;
        count++;
    }

    public T Remove(int index)
    {
        this.count--;
        var elementForRemove = data[index];
        for (int i = index; i < this.count; i++)
        {
            this.data[i] = this.data[i + 1];
        }
        var array = data;
        Array.Resize(ref array, count);
        this.data = array;
        return elementForRemove;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] != null)
            {
                if (data[i].Equals(element))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void Swap(int index1, int index2)
    {
        var firstElement = data[index1];
        var secondElement = data[index2];
        data[index1] = secondElement;
        data[index2] = firstElement;
    }

    public int CountGreaterThan(T element)

    {
        var counter = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] != null)
            {
                if (data[i].CompareTo(element) > 0)
                    counter++;
            }
        }
        return counter;
    }

    public T Max()
    {
        var maxElement = data[0];
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] != null)
            {
                if (data[i].CompareTo(maxElement) > 0)
                    maxElement = data[i];
            }
        }
        return maxElement;
    }

    public T Min()
    {
        var minElement = data[0];
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] != null)
            {
                if (data[i].CompareTo(minElement) < 0)
                    minElement = data[i];
            }
        }
        return minElement;
    }

    public void Sort()
    {
        T tmp;
        int min_key;

        for (int j = 0; j < data.Length- 1; j++)
        {
            min_key = j;

            for (int k = j + 1; k < data.Length; k++)
            {
                if (data[k] != null)
                {
                    if (data[k].CompareTo(data[min_key]) < 0)
                    {
                        min_key = k;
                    }
                }
            }
            tmp = data[min_key];
            data[min_key] = data[j];
            data[j] = tmp;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var element in data)
        {
            if (element != null)
                sb.AppendLine(element.ToString());
        }
        return sb.ToString().Trim();
    }
}
