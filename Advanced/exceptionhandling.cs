
var streamRead = new StreamReader(@"C:\file.zip");

try
{
  // Code here
  var result = 5 / 0;
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("you cannot divide by 0");
}
catch (ArithmeticException)
{
  Console.WriteLine("Sorry, an unexpected error occurred.");
}
catch (Exception ex)
{
  Console.WriteLine("Sorry, an unexpected error occurred.");
}
//Executes this code after the exception if you get one
finally
{
  //you want to close everything open.
  streamReader.Dispose();
}
//------------------------------------------------
//Using() will close a streamreader without having to use finally
try
{
  using(var streamReader = new StreamReader(@"c:/file.zip"))
  {
    var content = streamReader.ReadToEnd();
  }
}
catch (Exception ex)
{
  Console.WriteLine("Sorry, and unexpected error occurred.");
}
//------------------------------------------------------
public class YouTubeApi
{
  public List<Video> GetVideos(string user)
  {
    try
    {
      //Access Youtube web service
      //Read Data
      //Create a list of video objects
    }
    catch (Exception ex)
    {
      // Log
      throw new YouTubeException("Could not fetch the videos from youtube.", ex);
    }

    return new List<Video>();
  }
}

public class YouTubeException : Exception
{
  public YouTubeException(string message, Exception innerException)
    : base(message,innerException)
}
