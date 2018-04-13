using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Compatibility;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Problem2.Extended_Database;

[TestFixture]
public class DatabaseTests
{
    private Database database;
    private PropertyInfo propertyInfo;
    private Dictionary<string, int> peoplesInDatabase;

    [SetUp]
    public void DatabaseReflection()
    {
        this.database = new Database();
        PropertyInfo propertyInfo = typeof(Database).GetProperties(BindingFlags.Instance | BindingFlags.Public).First(x => x.Name == "Peoples");
    }


    [Test]
    public void TestDatabaseConstructor()
    {
        //Arrange

        //Act

        //Assert
        Assert.That(database.Peoples != null);
    }

    [Test]
    [TestCase("fsdfsdf", 432424L)]
    [TestCase("fsdfsdf", 432424L)]
    [TestCase("fsdfsdfsdf", 43298492L)]
    public void AddMethodValid(string name, long id)
    {
        //Arrange
        var people = new People(name, id);


        //Act
        database.Add(people);

        //Assert
        var username = people.Name;
        Assert.That(database.Peoples.ContainsKey(username));
    }

    [Test]
    [TestCase("fsdfsdf", 432424L)]
    [TestCase("fsdfsdf", 4324424L)]
    [TestCase("fsdfsdfsdf", 43298492L)]
    public void AddMethodInvalidUsername(string name, long id)
    {
        //Arrange
        var people = new People(name, 55555L);
        database.Add(people);

        //Act


        //Assert
        Assert.That(() => database.Add(people), Throws.InvalidOperationException);
    }

    [Test]
    [TestCase("fsdfsdf", 432424L)]
    [TestCase("fsdfsdf", 4324424L)]
    [TestCase("fsdfsdfsdf", 43298492L)]
    public void AddMethodInvalidId(string name, long id)
    {
        //Arrange
        var people = new People("Assss", id);
        database.Add(people);

        //Act

        //Assert
        Assert.That(() => database.Add(people), Throws.InvalidOperationException);
    }

    [Test]
    public void TestRemoveValid()
    {
        //Arrange
        var people1 = new People("dsf", 1111L);
        var people2 = new People("dsfsf", 2222L);
        database.Add(people1);
        database.Add(people2);

        //Act
        database.Remove();

        //Assert
        Assert.That(!database.Peoples.ContainsKey(people2.Name));
    }

    [Test]
    public void TestRemoveInvalid()
    {
        //Arrange
       
        //Act

        //Assert
        Assert.That(()=>database.Remove(),Throws.InvalidOperationException);
    }

    [Test]
    [TestCase("aaa")]
    [TestCase("bhfdsjhfj")]
    public void TestFindByUsernameValid(string user)
    {
        //Arrange
        var people1=new People(user,32132L);
        var people2=new People("bbb",321321L);
        database.Add(people1);
        database.Add(people2);

        //Act
      
        //Assert
        Assert.That(() => database.FindByUsername(user),Throws.Nothing);
    }

    [Test]
    [TestCase("aaa")]
    [TestCase("bhfdsjhfj")]
    public void TestFindByUsernameInalidExeption(string user)
    {
        //Arrange
        var people1 = new People("aa", 32132L);
        var people2 = new People("bb", 321321L);
        database.Add(people1);
        database.Add(people2);

        //Act

        //Assert
        Assert.That(() => database.FindByUsername(user), Throws.InvalidOperationException);
    }

    [Test]
    [TestCase("")]
    [TestCase(null)]
    public void TestFindByUsernameNullExeption(string user)
    {
        //Arrange
        var people1 = new People("dsdas", 32132L);
        var people2 = new People("bbb", 321321L);
        database.Add(people1);
        database.Add(people2);

        //Act

        //Assert
        Assert.That(() => database.FindByUsername(""), Throws.ArgumentNullException);
    }

    [Test]
    [TestCase(10L)]
    [TestCase(200L)]
    public void TestFindByIdValid(long id)
    {
        //Arrange
        var people1 = new People("aaa", id);
        var people2 = new People("bbb", 321321L);
        database.Add(people1);
        database.Add(people2);

        //Act

        //Assert
        Assert.That(() => database.FindById(id), Throws.Nothing);
    }

    [Test]
    [TestCase(10L)]
    [TestCase(200L)]
    public void TestFindByIdInalidExeption(long id)
    {
        //Arrange
        var people1 = new People("aaa", id);
        var people2 = new People("bbb", 321321L);
        database.Add(people1);
        database.Add(people2);

        //Act

        //Assert
        Assert.That(() => database.FindById(2L), Throws.InvalidOperationException);
    }

    [Test]
    [TestCase(0L)]
    [TestCase(-1L)]
    public void TestFindByIdOutOfRangeExeption(long id)
    {
        //Arrange
        var people1 = new People("fsdfsd", id);
        var people2 = new People("bbb", 321321L);
        database.Add(people1);
        database.Add(people2);

        //Act

        //Assert
        Assert.That(() => database.FindByUsername(""), Throws.ArgumentNullException);
    }


}

