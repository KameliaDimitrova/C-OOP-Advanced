using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.Extended_Database
{
    public class People
    {
        public string Name { get;private set; }
        public long  Id { get; private set; }

        public People(string name, long id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
