using System.Collections.Generic;
using System.ComponentModel;

namespace Open___Closed_and_Liskov.Models.Contracts
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }
        void Log(IError error);
    }
}