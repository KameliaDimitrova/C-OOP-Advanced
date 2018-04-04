using System.Linq;
using System.Reflection;
using _03BarracksFactory.Models.Units;

namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var currType = assembly.GetTypes()
                .First(t => t.Name == unitType);
            return (Unit)Activator.CreateInstance(currType);
        }
    }
}
