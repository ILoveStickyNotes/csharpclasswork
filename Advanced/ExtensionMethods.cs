//Main method
string post = "text here everywhere";
var shortenedPost = post.Shorten(5);
//Naming convention = Class you're extending and then Extensions

public static class StringExtensions
{
//must be public and static(this classextending)
  public static string Shorten(this String str, int numberOfWords)
  {
    if(numberOfWords < 0)
      throw new ArgumentOutOfRangeException("numberOfWords should be greater than 0");


    if (numberOfWords == 0)
      return "";

    var words = str.Split(' ');

    if(words.Length <= numberOfWords)
      return str;

    return string.Join(" ", words.Take(numberOfWords)) + "...";
  }
}
