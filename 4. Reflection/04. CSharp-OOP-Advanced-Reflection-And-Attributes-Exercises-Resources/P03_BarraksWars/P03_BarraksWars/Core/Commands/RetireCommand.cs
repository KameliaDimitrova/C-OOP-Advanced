using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Commands
{
    class RetireCommand:Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }
        public override string Execute()
        {
            Repository.RemoveUnit(Data[1]);
            string output = Data[1] + " retired!";
            return output;
        }
    }
}
