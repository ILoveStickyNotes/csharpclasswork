public class Point
{
  public int X;
  public int Y;

  public Point(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public void Move(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public void Move(Point newLocation)
  {
    if (newLocation == null)
      throw new ArgumentNullException("newLocation");
      
    Move(newLocation.X, newLocation.Y);
    //this.X = newLocation.X;
    //this.Y = newLocation.Y;
  }
}

public static void Main(string[] args)
  {
    var point = new Point(10,20);
    point.Move(new Point(40,60));
    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
  }
