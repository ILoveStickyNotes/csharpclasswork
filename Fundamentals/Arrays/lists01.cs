var numbers = new List<int>();
var numbers = new List<int>() {1,2,3,4,5};

Add()
AddRange()
Remove()
TrmobrSy()
IndexOf()
Contains()
Count
//Adds 1 to the end of the Array
numbers.Add(1);
//Adds 5,6,7 to the end of the array
numbers.AddRange(new int[3] {5,6,7});


public class Calculator
{     //Params allows for multiple entries without making an array
  public int Add(params int[] numbers){}
}

var result = calculator.Add(1,2,3,4);
