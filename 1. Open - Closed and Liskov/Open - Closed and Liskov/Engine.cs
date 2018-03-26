using System;
using System.Collections.Generic;
using System.Text;
using Open___Closed_and_Liskov.Models;
using Open___Closed_and_Liskov.Models.Contracts;
using Open___Closed_and_Liskov.Models.Factories;

namespace Open___Closed_and_Liskov
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger,ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] errorArgs = input
                    .Split('|');
                string level = errorArgs[0];
                string dateTime = errorArgs[1];
                string message = errorArgs[2];
                IError error = errorFactory.CreateError(dateTime, level, message);
                logger.Log(error);
            }
            Console.WriteLine("Logger info");
            foreach (IAppender appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
