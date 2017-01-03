public class Shape
{

}

public class Circle : Shape
{

}
//UPCASTING
Circle circle = new Circle();
Shape shape = circle;
//DOWNCASTING
Circle circle = new Circle();
Shape shape = circle;
Cricle anotherCircle = (Circle)shape;
//Object Casting Check
Car car = (Car) obj; // BAD
Car car = obj as Car;//Good
if (car != null)
{}
//--------------------------
if (obj is Car)
{
  Car car = (Car) obj;
}
//When you downcast something you get access to additional methods
private void Button_Click(object sender, RoutedEventArgs e)
{
  var button = (Button) sender;
  button.//additional methods from button
  //If unsure if runtime use var button = sender as Button;
  MessageBox.Show("Helloo World!");
  MessageBox.Show(button.ActualHeight.ToString());
}
