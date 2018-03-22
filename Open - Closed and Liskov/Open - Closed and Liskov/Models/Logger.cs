using System;
using System.Collections.Generic;
using System.Text;
using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models
{
   public class Logger:ILogger
   {
       private IEnumerable<IAppender> appenders;
        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

       public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>) this.appenders;

       public void Log(IError error)
       {
           foreach (IAppender appender in this.appenders)
           {
               if (appender.Level <= error.Level)
               {
                   appender.Append(error);
               }
           }
       }
   }
}
