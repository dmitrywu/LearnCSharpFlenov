int dowi = 0;

DayOfWeek dow = DayOfWeek.Wednesday;

Console.WriteLine("Day of Week: " + dow + "\nconvert to int: " + (int)dow);

DayOfWeek wd = DayOfWeek.Wednesday | DayOfWeek.Thursday;

Console.WriteLine(wd);

Console.WriteLine("Day of week: " + ((wd & DayOfWeek.Monday) != 0).ToString());
Console.WriteLine("Day of week: " + ((wd & DayOfWeek.Thursday) != 0).ToString());

DayOfWeek wt = (DayOfWeek)12;
Console.WriteLine(wt);


//[Flags]
enum DayOfWeek
{
    Monday = 0b_0000_0001,
    Tuesday = 0b_0000_0010,
    Wednesday = 0b_0000_0100,
    Thursday = 0b_0000_1000,
    Friday = 0b_0001_0000,
    Saturday = 0b_0010_0000,
    Sunday = 0b_0100_0000
}



//enum DayOfWeek : ushort
//{
//    Monday = 1,
//    Tuesday = 2,
//    Wednesday = 4,
//    Thursday = 8,
//    Friday = 16,
//    Saturday = 32,
//    Sunday = 64
//}

