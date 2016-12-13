string name = string.Format("{0} {1}", firstName, lastName);
//------------------------------------------------------------
var numbers = new int[3] {1,2,3};
string list = string.Join(",", numbers);
//------------------------------------------------------------
string name = "Mosh";
char firstChar = name[0];
//------------------------------------------------------------
string path = "c:\\projects\\project1\\folder1";
// Can use @ so you don't have to use escape chars so much
string path = @"c:\projects\project1\folder1";
//------------------------------------------------------------
var firstName = "Mosh";
var lastName = "bob";
var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
var names = new string[3] {"John", "Jack", "Mary"};
var formattedNames = string.Join(",", names);

//------------------------------------------------------------
ToLower()
ToUpper()
Trim()
IndexOf('a') //Search for character or string in a string
LastIndexOf("Hello") // Finds last location of hello in string
Substring(startIndex)// From start to finish
Substring(startIndex, length)// From start to where u want to end
Replace('a', '!')
Replace("Mosh", "moshfegh")
String.IsNullOrEmpty(str)
String.IsNullOrWhiteSpace(str)
str.Split(' ') //Splits a string
String s = "1234";
int i = int.Parse(s);
int j = Convert.ToInt32(s);
s.ToString("C"); //$1,234.00
s.ToString("C0"); //$1,234
//--------------------------------------------------------------------
//Remove excessive spacing
var fullName = "Bob Brown "; //<------ Extra space on end
var trimmed = fullName.Trim(); // "Bob Brown"

var index = fullName.IndexOf(' ');
var firstName = fullName.Substring(0, index);
var lastName = fullName.Substring(index + 1);
//Long way ^ Short way v
var names = fullName.Split(' ');
var firstName = names[0];
var lastName = names[1];
