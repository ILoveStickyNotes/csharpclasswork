

public void OnVideoEncoded(object source, EventArgs e)
{

}

//Delegate
//Agreement/Contract between publisher and subscriber
//Determines the signature of the event handler method in Subscriber

public class VideoEncoder
{
  //Define A Delegate
  //Define an event based on that Delegate
  //Raise the event
  //public event EventHandler<VideoEventArgs> VideoEncoded; Same thing as below
  public delegate void VideoEncodedEventHandler(object source, EventArgs args);
  public event VideoEncodedEventHandler VideoEncoded;

  public void Encode(Video Video)
  {
    Console.WriteLine("Encoding Vid....");
    Thread.Sleep(3000);

    OnVideoEncoded();
  }
//Event publisher methods should be protected,virtual,and void
//and start with "On"
  protected virtual void OnVideoEncoded()
  {
    if (VideoEncoded != null)
    {
      //EventArgs.Empty returns as empty
      VideoEncoded(this, EventArgs.Empty);
    }
  }
}

public class MailService
{
  public void OnVideoEncoded(object source, EventArgs e)
  {
    Console.WriteLine("Sending Email")
  }
}

//Main methods
static void Main(string[] args)
{
  var video = new Video() { Title = "Video 1"};
  var videoEncoder = new VideoEncoder(); //publisher
  var mailService = new MailService(); //Subscriber

  videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
  videoEncoder.Encode(video);
}
