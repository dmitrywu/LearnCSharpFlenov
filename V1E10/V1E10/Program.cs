int dowi = 0;

DayOfWeek dow = DayOfWeek.Wednesday;

Console.WriteLine("Day of Week: "+dow+"\nconvert to int: " + (int)dow);
enum DayOfWeek : ushort
{
    None = 0,
    Monday, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday
}

