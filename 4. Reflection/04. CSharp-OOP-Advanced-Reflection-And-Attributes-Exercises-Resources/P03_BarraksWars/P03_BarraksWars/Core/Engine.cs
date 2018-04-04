using System.Linq;
using System.Net.Mime;
using System.Reflection;
using P03_BarraksWars.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    if (commandName == "fight")
                        Environment.Exit(0);
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            commandName=commandName.First().ToString().ToUpper() + commandName.Substring(1);
            var assembly = Assembly.GetExecutingAssembly();
            var currClass = assembly.GetTypes().First(x => x.Name.StartsWith(commandName));
            var commandClass = ((Command)Activator.CreateInstance(currClass, data, repository, unitFactory)).Execute();
            return commandClass;
        }

    }
}
