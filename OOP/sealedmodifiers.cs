
//Sealed modifier disallows inheriting and is slightly faster
public sealed class Circle : Shape
{
  public /*sealed*/ override void Draw()
  {
    Console.WriteLine("Drawing a Circle");
  }
}
