namespace Open___Closed_and_Liskov.Models.Contracts
{
    public interface ILogFile
    {
        string Path { get; }
        int Size { get; }
        void WriteToFile(string errorLog);
    }
}