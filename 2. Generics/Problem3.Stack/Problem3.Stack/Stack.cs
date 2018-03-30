using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private  List<T> stack;

    public Stack(List<T> collection)
    {
        this.stack = new List<T>();
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < stack.Count; i++)
            yield return stack[i];
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public string Pop()
    {
        if (stack.Count == 0)
        {
            return "No elements";
        }
        stack.RemoveAt(stack.Count-1);
        return "";
    }

    public void Push(List<T> elements)
    {
      foreach (var element in elements)
        {
            stack.Add(element);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var printCounter = 1;
        while (printCounter < 3)
        {
            for(int i=stack.Count-1;i>=0;i--)
            {
                sb.AppendLine(stack[i].ToString());
            }
            printCounter++;
        }
        return sb.ToString().Trim();
    }
}

