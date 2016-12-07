// Instead of using
const int RegularAirMail = 1;
const int RegisteredAirMail = 2;
const int Express = 3;
//You can use an Enum
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3;
}
// Then it can be used like this
var method = ShippingMethod.Express;
//------------------------------------------------------------
using System;
namespace enumstuff
{
  public enum ShippingMethod
  {
      RegularAirMail = 1,
      RegisteredAirMail = 2,
      Express = 3;
  }

  class Program{
    static voic Main(string[] args)
    {
      var method = ShippingMethod.Express;
      Console.WriteLine((int)method);

      //When Receiving information you can cast it to the enum
      var methodId = 3;
      Console.WriteLine((ShippingMethod)methodId);
      //Takes the methodId and converts it to "Express"
      Console.WriteLine(method.ToString());

      var methodName = "Express";
      //Parsed a string to an enum
      var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
    }
  }
}
//------------------------------------------------------------
