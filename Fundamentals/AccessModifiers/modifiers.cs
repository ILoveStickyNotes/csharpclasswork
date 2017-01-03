Public - Accessible From Anywhere
Private - Accessible only from the class
Protected - Acessible only from the classs and derived classes *BAD Private is better*
Internal - Acessible from same assembly
Protected Internal -Acessible only from same assembly and derived classes *BAD*

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
  //Auto implemented property
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

//Type in username, problem(dropdown, -otherreason-), school, direct contact num,
//hardware affected(dropdown studentlaptop, -other-),
