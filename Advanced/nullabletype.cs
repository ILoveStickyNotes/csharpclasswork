//Ways to define a nullable

Nullable<DateTime> date = null;
Datetime? date = null;

date.GetValueOrDefault() //Best way to get a value
date.HasValue
date.Value //You'll get an exception because it's null (BAD WAY)

Datetime? date = null;
DateTime date2;

if (date != null)
  date2 = date.GetValueOrDefault();
else
  date2 = DateTime.Today;

  //Instead of the if statements use
  DateTime? date = null;
  //If date is null set date2 to DateTime.Today;
  DateTime date2 = date ?? Datetime.Today;
