// Constructor OVERLOADING
public class Customer
{
  public Customer() {...}
  public Customer(string name) {...}
  public Customer(int id, string name) {...}
}
//-------------------------------------------------------
public class Customer
{
  public int Id;
  public string Name;
  public List<Order> Orders;

  // Better to not use the methods below in the same way
  public Customer()
  {
    Orders = new List<Order>();
  }
  public Customer(string name)
    : this() //Calls the constructor without params: Customer()
  {
    this.Name = name;
  }
  public Customer(int id, string name)
    : this(name) //Calls the constructor: Customer(name)
  {
    this.Id = id;
  }
}
//--------------------------------------------------------------
public class Customer
{
  //Do it this way without having to initialize the list in the constructor
  //Always will be initialize
  List<Order> Orders = new List<Order>();
}
//-------------------------------------------
public class Customer
{
  readonly List<Order> Orders = new List<Order>();
}
