switch(role)
{
  case Role.Admin:
    Console.WriteLine("hi");
    break;
  case Role.Bob:
    Console.WriteLine("hi");
    break;
  default:
    Console.WriteLine("hi");
    break;
}
//------------------------------------------------------------
bool isGoldCustomer = true;

//float price;
//if (isGoldCustomer)
//  price = 19.95f;
//else
//  price = 29.95f;

//if isGoldCustomer is true, set price 19.95 if not 29.95
float price = (isGoldCustomer) ? 19.95f : 29.95f;

//------------------------------------------------------------
public enum Season
{
  Autumn,
  Summer,
  Winter;
}
class Program
{
  static voic Main(string[] args)
  {
      var season = Season.Autumn;

      switch (season)
      {
        case Season.Autumn:
        case Season.Summer:
          Console.WriteLine("It's Autumn or Summer");
          break;

        default:
          Console.WriteLine("I don't understand that season");
          break;
      }
  }
}
