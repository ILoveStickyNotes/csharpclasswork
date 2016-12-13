namespace Arrays
{
    class Program
    {
      static void Main(string[] args)
      {
        var numbers = new int[3]{1,2,3};
        Console.WriteLine(numbers)
      }
    }
}

var matrix = new int[3,5];
var matrix = new int[3,5]
{
  {1,2,3,4,5},
  {6,7,8,9,10},
  {11,12,13,14,15}
};

//Jagged Arrays
var array = new int[3][];
array[0] = new int[4];
array[1] = new int[5];
array[2] = new int[6];

array[0][0] = 1;

//Rectangular Array
var array = new int[3,5];

//Array is a class with these methods

//Gets the number at the array numbers at position 9
var index = Array.IndexOf(numbers, 9);

//Clear sets what you defined to either 0 for ints, false for bools, null for strings
//From 0 to 2 in the array
Array.Clear(numbers, 0 , 2);
Array.Sort(numbers);
Array.Reverse(numbers);
Array.Copy(numbers, anotherarray, 3);
