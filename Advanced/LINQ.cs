//Language Integrated Query

//Lets you query objects in memory  (Linq to objects)
//Databases (Linq to Entities)
//XML (Linq to XML)
//ADO.NET Data sets (Linq to Data Sets)

public class Book
{
  public string Title {get; set;}
  public float Price {get; set;}
}

public class BookRepository
{
  public IEnumerable<Book> GetBooks()
  {
    return new List<Book>
    {
      new Book() {Title = "A", Price = 5},
      new Book() {Title = "b", Price = 9.99f},
      new Book() {Title = "c", Price = 12},
      new Book() {Title = "d", Price = 7},
      new Book() {Title = "e", Price = 9}
    };
  }
}

class Program
{
  static void Main(string[] args)
  {
    var books = new BookRepository().GetBooks();

    //LINQ Query Operators
    var cheaperBooks =
        from b in books
        where b.Price<10
        orderby b.Title
        select b.Title;

    //LINQ Extension Methods same as above and better
    var cheapBooks = books
                        .Where(b => b.Price < 10)
                        .OrderBy(b => b.Title)
                        .Select(b => b.Title);

   foreach (var book in cheapBooks)
    Console.WriteLine(book);
//-------------------------------------------------
//How to select a single item in a list
  var books = new BookRepository().GetBooks();
  var book = books.Single(b => b.Title == "ASP.NET MVC");
  var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
  var book = books.First(b => b.Title == "ASP.NET MVC");
  var book = books.FirstOrDefault(b => b.Title == "ASP.NET MVC");
  var book = books.Last(b => b.Title == "ASP.NET MVC");
  Console.WriteLine(book.Title);
//------------------------------------------------
  var books = new BookRepository().GetBooks();
  //Skips 2 objects and returns the last 3
  var pagedBooks = books.Skip(2).Take(3);

  foreach (var pagedBook in pagedBooks)
  {
    Console.WriteLine(pagedBook.Title);
  }
//-----------------------------------------------------
var count = books.Max(b => b.Price);
//^ Book with highest price
  }
}
