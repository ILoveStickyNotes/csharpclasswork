//User this if it doesn't return anything
public async Task MethodNameAsync(){}
//Use this if it returns something
public async Task<T> MethodNameAsync(){}
//--------------------------------------------------------
//await means not to wait for the result and continue execution
//can only use await in a async method
//---------------------------------------------------------
private void Button_Click(object sender, RoutedEventArgs e)
{
  //DownloadHtml("http://msdn.microsoft.com");
  var html = GetHtml("http://msdn.microsoft.com");
  MessageBox.Show(html.Substring(0,10));
}
// Async
private async void Button_Click(object sender, RoutedEventArgs e)
{
  var getHtmlTask = GetHtmlAsync("http://google.com");
  MessageBox.Show("Waiting for task to complete");

  var html = await getHtmlTask;
  MessageBox.Show(html.Substring(0,10));
}

public string GetHtml(string url)
{
  var webClient = new WebClient();

  return webClient.DownloadString(url);
}

public async Task<string> GetHtmlAsync(string url)
{
  var webClient = new WebClient();
  return await webClient.DownloadStringTaskAsync(url);
}

public async Task DownloadHtmlAsync(string url)
{
  var webClient = new WebClient();
  var html = await webClient.DownloadStringTaskAsync(url);

  using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
  {
    await streamWriter.WriteAsync(html);
  }
}
