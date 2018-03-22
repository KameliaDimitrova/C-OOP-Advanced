using System;

namespace Open___Closed_and_Liskov.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        ErrorLevel Level { get; }
    }
}