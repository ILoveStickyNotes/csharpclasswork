Public
Private
Protected
Internal
Protected Internal

//Private variables should be like this
private string _name;

//Properties
public class Person
{
  private DateTime _birthdate;
  public DateTime Birthdate
  {
    get {return _birthdate;}
    set {_birthdate = value;}
  }
}
//AutoImplemented Properties
public class Person
{

  public DateTime Birthdate { get; private set; }

  public Person(DateTime birthdate)
  {
    Birthdate = birthdate;
  }

  public int Age
  {
    get
    {
      var timeSpan = DateTime.Today - Birthdate;
      var years = timeSpan.Days/365;
      return years;
    }
  }
}

//MainMethod
var person = new Person(new DateTime(1982,1,1));
//person.Birthdate = new DateTime(1982,1,1);
Console.WriteLine(person.Age);
