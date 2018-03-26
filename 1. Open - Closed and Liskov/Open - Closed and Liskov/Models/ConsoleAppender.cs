using System;
using System.Collections.Generic;
using System.Text;
using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models
{
   public class ConsoleAppender:IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel errorLevel)
        {
            this.Layout = layout;
            this.Level = errorLevel;
        }

        public ILayout Layout { get; }
        public ErrorLevel Level { get; }
        public int MessagesApended { get; private set; }

        public void Append(IError error)
        {
            string formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);
            this.MessagesApended++;
        }

        public override string ToString()
        {
            string result =
                $"Appender type: {this.GetType().Name}, Layout type: {this.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.MessagesApended}";
            return result;
        }
    }
}
