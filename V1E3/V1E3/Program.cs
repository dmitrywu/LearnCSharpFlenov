Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;

int? idx = null;
string? strin = null; // string strin = null;

if (idx == null)
{
    Console.WriteLine($"is null\n");

}

const double Pi = 3.14;
Console.WriteLine($"{Pi}\n");

string sarray = "Hello";

foreach (char c in sarray)
{
    if (c == 'l') continue;
    
    Console.WriteLine(c);
}

Console.WriteLine($"\n");

int[] array = { 20,19,30,5, 50 };
int min = array[0];
int max = array[1];
//for (int j = 0; j < 5; j++)
foreach (int j in array ) // int потому что массив int, i - сами значения из массива
{
    //Console.WriteLine($"{array[j]}");
    //if (min > array[i]) { min = array[i]; } 
    //if (max < array[i]) { max = array[i]; }
    if (min > j) min = j;
    if (max < j) max = j;
    Console.WriteLine(j.ToString() + " " + min.ToString() + " " + max.ToString());
    
}

Console.WriteLine($"min = {min},\tmax = {max}\n");


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int index = 0;
int sum = 0;
//for (int index = 0; index < 10; index++)
// for (int index=0, j=0; index <10 && j<20; index=index+2, j=j+2);

for (; index < 10; index++)
{
    //Console.WriteLine($"index = {index}");
    // Console.WriteLine("index & str" + index);
    sum += index;
}

Console.WriteLine("for sum = "+sum);


int i = 0;
sum = 0;

while (i < 10) // for (; i< 10;) тоже самое
{
    sum=sum+i;
    i++;
}

Console.WriteLine($"summ (while) = {sum}");

sum = 0; i = 10;
do // выполнится хотя бы один раз, потому что условия выполнятеся в самом конце
{
    sum = sum+i;
    i++;
}  while (i < 10);

Console.WriteLine($"summ (do-while) = {sum}");

