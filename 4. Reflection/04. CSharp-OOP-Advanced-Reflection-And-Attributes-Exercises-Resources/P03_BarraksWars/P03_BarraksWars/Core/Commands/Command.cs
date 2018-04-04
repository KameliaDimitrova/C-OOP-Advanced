using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core;
using _03BarracksFactory.Models.Units;

namespace P03_BarraksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        
        protected Command(string [] data, IRepository repository,IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }
        private string[] data;

        public string[] Data
        {
            get { return data; }
            set { data = value; }
        }

        private IRepository repository;

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        private IUnitFactory unitFactory;

        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }
    
        public abstract string Execute();

    }
}
