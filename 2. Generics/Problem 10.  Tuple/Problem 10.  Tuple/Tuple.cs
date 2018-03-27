public class Tuple<TKey1,TKey2>
{
    public TKey1 Key1 { get; private set; }
    public TKey2 Key2 { get; private set; }
    public Tuple(TKey1 key1,TKey2 key2)
    {
        this.Key1 = key1;
        this.Key2 = key2;
    }
    public override string ToString()
    {
        return $"{Key1} -> {Key2}";
    }
}
