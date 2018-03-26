using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }
    public Box()
    { }
    public string SwapTwoElements(List<T> listForSwapping, int firstIndex, int secondIndex)
    {
        var firstElement = listForSwapping[firstIndex];
        var secondElement = listForSwapping[secondIndex];
        listForSwapping[firstIndex] = secondElement;
        listForSwapping[secondIndex] = firstElement;
        var sb = new StringBuilder();
        foreach (var element in listForSwapping)
        {
            sb.AppendLine($"{element.GetType().FullName}: {element}");
        }
        return sb.ToString().Trim();
    }

    public override string ToString()
    {
        var result = $"{this.value.GetType().FullName}: {value}";
        return result;
    }
}

