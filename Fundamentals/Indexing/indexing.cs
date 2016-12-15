public class HttpCookie
{
  public string this[string key]
  {
    get{..}
    set{..}
  }
}
//------------------------------
public class HttpCookie
{                //Keys will be of type string as well as the value
  private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
  public DateTime Expiry { get; set; }
  //public HttpCookie()
  //{
  //  _dictionary = new Dictionary<string, string>();
  //}
  public string this[string key]
  {
    get{return _dictionary[key];}
    set{_dictionary[key] = value;}
  }
}
//MM
var cookie = new HttpCookie();
cookie["name"] = "Mosh"
