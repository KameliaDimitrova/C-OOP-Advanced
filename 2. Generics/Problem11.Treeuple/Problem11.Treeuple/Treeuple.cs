public class Treeuple<TKey1,TKey2,TKey3>
{
    public TKey1 Key1 { get;  }
    public TKey2 Key2 { get;  }
    public TKey3 Key3 { get;  }

    public Treeuple(TKey1 key1,TKey2 key2, TKey3 key3)
    {
        this.Key1 = key1;
        this.Key2 = key2;
        this.Key3 = key3;
    }

    public override string ToString()
    {
        return $"{this.Key1} -> {this.Key2} -> {this.Key3}";
    }
}

