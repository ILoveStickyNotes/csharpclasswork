//A Class can inherit multiple base classes
//When a class inherits, it inherits all the code from the UiControl class
//When a interface is implemented, it's forced to use interface's methods
public class TextBox : UiControl, IDraggable, IDroppable
{

}

public class UiControl
{
  public string Id {get; set;}
  public Size Size {get; set;}
  public Position TopLeft {get; set;}

  public virtual void Draw()
  {

  }
  public void Focus()
  {
    Console.WriteLine("Received Focus");
  }
}
