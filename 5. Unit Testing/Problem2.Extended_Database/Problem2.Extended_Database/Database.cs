using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Problem2.Extended_Database;

public class Database
{
    public Dictionary<string,long> Peoples { get; private set; }

    public Database()
    {
        this.Peoples=new Dictionary<string, long>();
    }

    public void Add(People inputPeople)
    {

        if (Peoples.ContainsKey(inputPeople.Name)||Peoples.ContainsValue(inputPeople.Id))
        {
            throw new InvalidOperationException();
        }
        Peoples[inputPeople.Name] = inputPeople.Id;
    }

    public void Remove()
    {
        if (Peoples.Count<=0)
        {
            throw new InvalidOperationException();
        }
        Peoples.Remove(Peoples.Keys.Last());
    }

    public bool FindByUsername(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentNullException();
        }
        if (!Peoples.ContainsKey(username))
        {
            throw new InvalidOperationException();
        }
        
        var user = this.Peoples.Where(x => x.Key == username).Select(x => x.Key).First();
        return true;
    }

    public bool FindById(long id)
    {
        if (id < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (!Peoples.ContainsValue(id))
        {
            throw new InvalidOperationException();
        }
       
        var user = this.Peoples.Where(x => x.Value == id).Select(x => x.Key).First();
        return false;
    }
}

