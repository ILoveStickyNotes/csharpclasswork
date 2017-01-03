//A delegate is an object that know show to call a method
//or group of methods
//A reference to a function

public class PhotoProcessor
{

  public delegate void PhotoFilterHandler(Photo photo);

  public void Process(string path, PhotoFilterHandler filterHandler)
  {
    var photo = Photo.Load(path);
    filterHandler(photo);
    photo.Save();
  }
}
//--------------------Main method
static void Main(string[] args)
{
  var processor = new PhotoProcessor();
  var filters = new PhotoFilters();
  PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
  filterHandler += filters.ApplyContrast;

  processor.Process("photo.jpg", filterHandler)
}
//--------------------------------------------
public class PhotoProcessor
{
// You can use these instead of creating a delegate
  public void Process(string path, Action<Photo> filterHandler)
  {
    var photo = Photo.Load(path);
    filterHandler(photo);
    photo.Save();
  }
}
//--------------------Main method
static void Main(string[] args)
{
  var processor = new PhotoProcessor();
  var filters = new PhotoFilters();
  // You can use these instead of creating a delegate
  Action<Photo> filterHandler = filters.ApplyBrightness;
  filterHandler += filters.ApplyContrast;

  processor.Process("photo.jpg", filterHandler)
}
