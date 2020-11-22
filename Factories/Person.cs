using System;
using NUnit.Framework;

namespace Coding.Exercise
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }
	
    public override string ToString() 
    {
      return $"My name is {Name} and my id is {Id}";
    }
  }

  public class PersonFactory
  {
    private static int i = 0;
    public Person CreatePerson(string name)
    {
        return new Person {Id = i++, Name = name};
    }
  }

  public class Exercise
  {
    static void Main(string[] args)
    {
      var factory = new PersonFactory();
      var p = factory.CreatePerson("Juan");
      Console.WriteLine(p);
      var p2 = factory.CreatePerson("Antonio");
      Console.WriteLine(p2);
    }
  }
}

namespace Coding.Exercise.UnitTests
{
  [TestFixture]
  public class FirstTestSuite
  {
    [Test]
    public void Test()
    {
      var pf = new PersonFactory();

      var p1 = pf.CreatePerson("Juan");
      Assert.That(p1.Name, Is.EqualTo("Juan"));
      Assert.That(p1.Id, Is.EqualTo(0));

      var p2 = pf.CreatePerson("Antonio");
      Assert.That(p2.Id, Is.EqualTo(1));
    }
  }
}
