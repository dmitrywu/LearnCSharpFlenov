// See https://aka.ms/new-console-template for more information

/* 
 * comment variant
 */

Console.Clear();

Console.WriteLine("Hello, World!");

int i = 2;
double d = 1.2232;
Int32 i32 = 1;

int
    b
    =
    4
    ;

i = 10;
d = 213;

string s;
s = "tesst";
char c = 'A';

int i1 = 1, i2 = 2, i3 = 3;

int[] arrayint = new int[100];
double[] darrr = new double[10];
//string[] weakdays = new string[7];
//weakdays[0] = "Понедельник";
string[] weekdays = {"Понедельник", "Вторник", "Среда" };

int[,] doarray = new int[10,20];
doarray[1, 5] = 10;

arrayint[0] = 4;
arrayint[1] = 10; 
arrayint[2] = 20;

Console.WriteLine($"{i}, {i32}, {s}, \t {c} \t {arrayint[1]}, \t {weekdays[1]}");

MyEnum test1 = MyEnum.Вторник;

Console.WriteLine($"{test1}");
Console.WriteLine($"{(int)test1}");

enum MyEnum { Понедельник, Вторник=20, Среда };