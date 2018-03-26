using System;
using System.Collections.Generic;
using System.Text;
using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models
{
  public  class Error:IError
    {
        public DateTime DateTime { get; }
        public string Message { get; }
        public ErrorLevel Level { get; }

        public Error(DateTime dateTime, ErrorLevel level, string message)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Message = message;
        }
    }
}
