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
