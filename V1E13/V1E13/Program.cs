using System.Runtime.Intrinsics.Arm;

trydiv(4, 2);
trydiv(4, 0);


while (true)
{
    Console.WriteLine("Enter number: ");
    string line = Console.ReadLine();
    if (line == "q") break;

    try
    {
        int number = Int32.Parse(line);
        // int number = Convert.ToInt32(line);
        Console.WriteLine("num: " + number.ToString());
    }
    catch (Exception)
    {
        Console.WriteLine("Incorrect number");
    }
    //catch(ArgumentNullException) {
    //    Console.WriteLine();
    //}
}

//SystemException
//ApplecationException

void trydiv(int x, int y)
{
    try
    {
        Console.WriteLine(div(x, y));
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (MyDivByZeroException e)
    {
        Console.WriteLine($"Do not devide {e.x} by {e.y}");
            }
}

double div(int x, int y)
{
    if (y == 0)
        throw new MyDivByZeroException(x, y);

    return x / y;
}

public class MyDivByZeroException : ApplicationException
{
    public int x { get; set; }
    public int y { get; set; }
    public MyDivByZeroException(int x, int y)
    {
        this.x = x;
        this.y = y;

    }

}