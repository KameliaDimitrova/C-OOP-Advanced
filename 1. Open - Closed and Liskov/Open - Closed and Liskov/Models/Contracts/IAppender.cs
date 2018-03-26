namespace Open___Closed_and_Liskov.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get;  }
        ErrorLevel Level { get; }
        void Append(IError error);
    }
}