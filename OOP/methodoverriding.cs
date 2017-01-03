public class Shape
{
  public virtual void Draw()
  {
    // Default implementation
  }
}

public class Circle : Shape
{
  public override void Draw()
  {
    // New implementation |
    //Choose what the draw method does to the circle object
  }
}
// Making this abstract makes the dervied classes have
// to create the implementation because this method has none.
// No implementation. Class has to be abstract too.
// var shape = new Shape(); will not compile
public abstract class Shape
{
  public abstract void Draw();
}
