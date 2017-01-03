//Interfaces are good for loose coupling and extensibility/testing

public interface IShippingCalculator
{
  float CalculateShipping(Order order)
}
//                    : =  Implements IShippingCalculator interface
public class ShippingCalculator : IShippingCalculator
{
  public float CalculateShipping(Order order)
  {
    //method here
    return 0;
  }
}
//--------------------------------------------------------------
//Extensibility/Dependency Injection
public interface ILogger
{
  void LogError(string message);
  void LogInfo(string message);
}

//This class Changes the behavior without changing the code
//OCP programming Open Close Principal
//Closed for modification Open for extension
public class DbMigrator
{
  private readonly ILogger _logger;

  public DbMigrator(ILogger logger)
  {
    _logger = logger;
  }

  public void Migrate()
  {
    _logger.LogInfo("Migration Started at {0}" + DateTime.Now);
    //Console.WriteLine("Migration Started at {0}", DateTime.Now);
    //Method
    //Console.WriteLine("Migration Stopped at {0}", DateTime.Now);
    _logger.LogInfo("Migration Stopped at {0}" + DateTime.Now);
  }
}

public class ConsoleLogger : ILogger
{
  public void LogError(string message)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
  }
  public void LogInfo(string message)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
  }
}

public class FileLogger : ILogger
{

  private readonly string _path;

  public FileLogger(string path)
  {
    _path = path;
  }
  public void LogError(string message)
  {
    Log(message, "Error");
  }
  public void LogInfo(string message)
  {
    Log(message, "Info");
  }
  private void Log(string message, string messageType)
  {
    //streamWriter doesn't Compile with CLR. Using() takes care of everything
    using(var streamWriter = new StreamWriter(_path, true))
    {
      streamWriter.WriteLine("Error" + message);
    }
  }
}

class Program
{
  static void Main(string[] args)
  {
    var dbMigrator = new DbMigrator(new ConsoleLogger());
    dbMigrator.Migrate();
  }
}
