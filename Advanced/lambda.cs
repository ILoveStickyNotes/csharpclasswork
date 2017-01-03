//No access modifier, name, or return
//args => expression
//() => ...
//x => ...
//(x,y,z) => ...
static void Main(string[] args)
{
  //number => number*number This is the same as the Square Method

  Func<int, int> square = number => number*number;
  Console.WriteLine(square(5));



  //Console.WriteLine(Square(5));
}

//static int Square(int number)
//{
//  return number*number
//}

//------------------------------------------
//Main Method
{
  const int factor = 5;
  // n goes to n times factor
  Func<int,int> multiplier = n => n*factor;
  var result = multiplier(10);
  //Outputs 50
}
//---------------------------------------------------
public List<Book> GetBooks()
{
  return new List<Book>
  {
    new Book() {Title = "Title 1", Price = 5},
    new Book() {Title = "Title 1", Price = 7},
    new Book() {Title = "Title 1", Price = 57}
  };
}

//Main method
{
  var books = new BookRepository().GetBooks();
  //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
  // No need to have that method when you can use this lambda expression
  var cheapBooks = books.FindAll(book => book.Price < 10);
  foreach (var book in cheapBooks)
  {
    Console.WriteLine(book.Title);
  }
}

//Predicate method
static bool IsCheaperThan10Dollars(Book book)
{
  return book.Price < 10;
}
