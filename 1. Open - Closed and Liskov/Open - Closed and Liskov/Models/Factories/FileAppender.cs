using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models.Factories
{
    internal class FileAppender : IAppender
    {
   
        private ILogFile logFile;

        public FileAppender(ILayout layout, ErrorLevel errorLevel, ILogFile logFile)
        {
            this.Layout = layout;
            this.Level = errorLevel;
            this.logFile = logFile;
        }

        public ILayout Layout { get; }
        public ErrorLevel Level { get; }
        public int MessagesApended { get;private set; }
        public void Append(IError error)
        {
            string formattedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formattedError);
            this.MessagesApended++;
        }

        public override string ToString()
        {
            string result =
                $"Appender type: {this.GetType().Name}, Layout type: {this.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.MessagesApended}, File size: {this.logFile.Size}";
            return result;
        }
    }
}