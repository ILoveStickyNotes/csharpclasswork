// DateTime(int year, int month, int day)
var dateTime = new DateTime(2015,2,5);
var now = DateTime.Now;
var today = DateTime.Today;

now.Hour;
now.Minute;
var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToLongTimeString());

//Gives Date and Time
Console.WriteLine(now.ToString());
//Custom Date formatting
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
//hour, Minute, second
var timeSpan = new Timespan(1,2,3);
var timeSpan1 = new Timespan.FromHours(1);

var start = DateTime.Now;
var end = Datetime.Now.AddMinutes(2);
var duration = end - start;
Console.WriteLine("Duration : " + duration);
//It will Print 2

timeSpan.Minutes // Returns what you put in (2)
timeSpan.TotalMinutes // Adds up everything and reurns (62.05)

timeSpan.Add(TimeSpan.FromMinutes(8)); // Adds 8mins to what you set
timeSpan.Subtract(TimeSpan.FromMinutes(8)); // subtracts 8mins to what you set

//Parse time entered
TimeSpan.Parse("01:02:03");
