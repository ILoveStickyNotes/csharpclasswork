public class GenericList<T>
{
  public void Add(T value)
  {

  }

  public T this[int index]
  {
    get{throw new NotImplementedException();}
  }
}

static void Main(string[] args)
{
  var book = new Book {Isbn = "1111", Title = "C# Advanced"};

//  var numbers = new List();
// numbers.Add(10);
//  var books = new BookList();
//  books.Add(book);
  var numbers = new GenericList<int>();
  numbers.Add(10);

  var books = new GenericList<Book>();
  books.Add(new Book());
  //Reference for generics System.Collectons.Generic.
}

public class GenericDicitonary<TKey, TValue>
{
  public void Add(TKey key,TValue value)
  {

  }
}

public class Utilities//<T> where T : IComparable
{
  public int Max(int a,int b)
  {
    return a > b ? a : b;
  }
// Adding constraint to the generic method
// where T : IComparable checks if there types can be compared
  public T Max<T>(T a, T b) where T : IComparable
  {
    return a,CompareTo(b) > 0 ? a : b;
  }
}
//-----------------------------------------------
//Constraints
// Where T : IComparable [given interface]
// Where T : Product [given type or subclasses]
// Where T : Struct [value type]
// Where T : class [reference type]
// Where T : new() [default constructor]
//------------------------------------------------
public class DiscountCalculator<TProduct> where TProduct : Product
{
  public float CalculateDiscount(TProduct product)
  {
    return product.Price;
  }
}
//------------------------------------------------------
public class Nullable<T> where T : struct
{
  private object _value;

  public Nullable(T value)
  {
    _value = value;
  }

  public bool HasValue
  {
    get { return _value != null; }
  }

  public T GetValueOrDefault()
  {
    if (HasValue)
      return (T)_value;

    return default(T);
  }
}
//--------------------------------------------------------
