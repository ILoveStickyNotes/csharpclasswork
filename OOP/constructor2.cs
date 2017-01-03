Base Keyword
//Inherits constructors from other classes

public class Vehicle
{
  private string _registrationNumber;
  public Vehicle(string registrationNumber)
  {
    _registrationNumber = registrationNumber;
  }
}
public class Car : Vehicle
{
  public Car(string registrationNumber)
    : base(registrationNumber) // : base accesses the private variable in Vehicle Class
    {
      //blah blah
    }
}
